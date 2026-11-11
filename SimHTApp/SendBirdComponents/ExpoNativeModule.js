import {
  createExpoClipboardService,
  createExpoFileService,
  createExpoMediaService,
  createExpoNotificationService,
  createExpoPlayerService,
  createExpoRecorderService,
} from "@sendbird/uikit-react-native";
import { Platform } from "react-native";
import { isRunningInExpoGo } from "expo";

import * as ExpoClipboard from "expo-clipboard";
import * as ExpoDocumentPicker from "expo-document-picker";
import * as ExpoFS from "expo-file-system";
import * as ExpoImagePicker from "expo-image-picker";
import * as ExpoMediaLibrary from "expo-media-library";
import * as ExpoAudio from "expo-audio";
import * as ExpoVideo from "expo-video";
import * as ExpoVideoThumbnail from "expo-video-thumbnails";
import * as ExpoImageManipulator from "expo-image-manipulator";

const isAndroidExpoGo = Platform.OS === "android" && isRunningInExpoGo();
const notificationService = isAndroidExpoGo
  ? {
      getAPNSToken: async () => null,
      getFCMToken: async () => null,
      hasPushPermission: async () => false,
      requestPushPermission: async () => false,
      onTokenRefresh: () => undefined,
    }
  : createExpoNotificationService(require("expo-notifications"));

export const platformServices = {
  clipboard: createExpoClipboardService(ExpoClipboard),

  notification: notificationService,

  file: createExpoFileService({
    fsModule: ExpoFS,
    imagePickerModule: ExpoImagePicker,
    mediaLibraryModule: ExpoMediaLibrary,
    documentPickerModule: ExpoDocumentPicker,
  }),

  media: createExpoMediaService({
    avModule: ExpoVideo,
    thumbnailModule: ExpoVideoThumbnail,
    imageManipulator: ExpoImageManipulator,
    fsModule: ExpoFS,
  }),

  player: createExpoPlayerService({
    avModule: ExpoAudio,
  }),

  recorder: createExpoRecorderService({
    avModule: ExpoAudio,
  }),
};

export default platformServices;
