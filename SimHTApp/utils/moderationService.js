import SendBird from "sendbird";
import axios from "axios";
import Config from "../constants/Config";
import { formatModerationReport } from "./contentModeration";

const moderationHeaders = (userToken) => ({
  Accept: "application/json",
  "Content-Type": "application/json",
  ...(userToken ? { Authorization: `Bearer ${userToken}` } : {}),
});

const getApiResult = (response) => {
  const result = response?.data;
  if (result?.code != null && String(result.code) !== "1") {
    throw new Error(result.message || "Không thể thực hiện yêu cầu kiểm duyệt.");
  }
  return result;
};

export const reportPost = async ({ userId, postId, reason, userToken }) => {
  if (userId == null || postId == null) {
    throw new Error("Missing user id or post id for report");
  }

  const response = await axios.post(
    `${Config.BASE_URL}/api/post/report-post`,
    {
      userID: userId,
      postID: postId,
      reason: reason || "Nội dung không phù hợp",
    },
    { headers: moderationHeaders(userToken) },
  );

  return getApiResult(response);
};

export const blockUser = async ({ userId, blockedUserId, userToken }) => {
  if (userId == null || blockedUserId == null) {
    throw new Error("Missing user id for block");
  }

  const response = await axios.post(
    `${Config.BASE_URL}/api/post/block-user`,
    {
      userID: userId,
      blockedUserID: blockedUserId,
    },
    { headers: moderationHeaders(userToken) },
  );

  return getApiResult(response);
};

const connect = (client, userId) =>
  new Promise((resolve, reject) => {
    client.connect(String(userId), (user, error) => {
      if (error) reject(error);
      else resolve(user);
    });
  });

const createSupportChannel = (client, reporterUserId) =>
  new Promise((resolve, reject) => {
    const params = new client.GroupChannelParams();
    params.isDistinct = true;
    params.addUserIds([String(reporterUserId), Config.SEND_BIRD_SUPPORT_ID]);

    client.GroupChannel.createChannel(params, (channel, error) => {
      if (error) reject(error);
      else resolve(channel);
    });
  });

const sendMessage = (channel, message) =>
  new Promise((resolve, reject) => {
    channel.sendUserMessage(message, (sentMessage, error) => {
      if (error) reject(error);
      else resolve(sentMessage);
    });
  });

export const notifyModerationTeam = async ({ reporterUserId, ...report }) => {
  if (reporterUserId == null) {
    throw new Error("Missing reporter user id");
  }

  const client = new SendBird({ appId: Config.SEND_BIRD_APP_ID });
  await connect(client, reporterUserId);
  const supportChannel = await createSupportChannel(client, reporterUserId);
  await sendMessage(
    supportChannel,
    formatModerationReport({ reporterUserId, ...report }),
  );
};

export const blockSendbirdUser = async ({ currentUserId, targetUserId }) => {
  if (currentUserId == null || targetUserId == null) {
    throw new Error("Missing user id for block");
  }

  const client = new SendBird({ appId: Config.SEND_BIRD_APP_ID });
  await connect(client, currentUserId);

  await new Promise((resolve, reject) => {
    client.blockUserWithUserId(String(targetUserId), (user, error) => {
      if (error) reject(error);
      else resolve(user);
    });
  });
};
