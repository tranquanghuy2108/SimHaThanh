import React, { useCallback, useContext } from "react";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import { Home, ImagePreview, PostDetails } from "../screens/PostScreens";
import { Text, TouchableOpacity } from "react-native";
import Ionicons from "react-native-vector-icons/Ionicons";
import { useNavigation } from "@react-navigation/native";
import { PostContext } from "../context/PostContext";
import CreatePostScreen from "../screens/PostScreens/CreatePostScreen";
import { argonTheme } from "../constants";
import {
  responsiveFontSize,
  responsiveHeight,
} from "react-native-responsive-dimensions";

const Stack = createNativeStackNavigator();

const CreatePostHeaderButton = () => {
  const navigation = useNavigation();
  const { SetHitPost } = useContext(PostContext);

  const handleCreatePost = useCallback(() => {
    SetHitPost(true);
    navigation.navigate("FacebookFeedHome");
  }, [navigation, SetHitPost]);

  return (
    <TouchableOpacity
      onPress={handleCreatePost}
      className="flex-row justify-center items-center"
    >
      <Ionicons name="navigate-outline" color="green" size={25} />
      <Text className="font-bold mx-2">Đăng</Text>
    </TouchableOpacity>
  );
};

export default function PostStack() {
  return (
    <Stack.Navigator>
      <Stack.Screen
        options={({ navigation }) => ({
          title: "Chợ SIM",
          headerRight: () => (
            <TouchableOpacity
              onPress={() => navigation.navigate("CreatePostScreen")}
              className="flex-row justify-center items-center"
              style={{
                paddingHorizontal: 0,
                paddingVertical: 0,
                minHeight: 50,
              }}
            >
              <Ionicons name="create-outline" color="white" size={23} />
              <Text className="font-bold" style={{ color: "white" }}>
                Đăng Bài
              </Text>
            </TouchableOpacity>
          ),
          headerStyle: {
            backgroundColor: argonTheme.COLORS.ERROR,
            height: responsiveHeight(12),
          },
          headerTitleAlign: "center",
          headerTintColor: "white",
          headerTitleStyle: {
            fontSize: responsiveFontSize(2.5),
            fontWeight: "bold",
            includeFontPadding: false,
          },
          headerTitleContainerStyle: {
            paddingTop: 0,
            maxHeight: 70,
          },
          headerRightContainerStyle: {
            paddingTop: 0,
            maxHeight: 50,
          },
        })}
        name="FacebookFeedHome"
        component={Home}
      />
      <Stack.Screen
        name="FacebookFeedPostDetails"
        // options={({ route }) => ({ title: `${route.params.post.creator.name}'s Post` })}
        component={PostDetails}
      />
      <Stack.Screen
        options={{ title: "" }}
        name="FacebookFeedImagePreview"
        component={ImagePreview}
      />

      <Stack.Screen
        options={{
          title: "Đăng bài",
          headerRight: () => <CreatePostHeaderButton />,
          headerStyle: {
            backgroundColor: argonTheme.COLORS.ERROR,
            height: responsiveHeight(12),
          },
          headerTintColor: "white",
          headerTitleStyle: {
            fontSize: responsiveFontSize(2.5),
            includeFontPadding: false,
          },
        }}
        name="CreatePostScreen"
        component={CreatePostScreen}
      />
    </Stack.Navigator>
  );
}
