import React from 'react';
import {ScrollView, Text, Image, View, SafeAreaView } from 'react-native';
import MasonryList from '@react-native-seoul/masonry-list';
import Banner from '../customComponents/Banner';

const aboutDatas = [
    { name: 'Tra số', id: 1, des: ["Tra cứu hotline các đại lý", "Mua sim với giá gốc"], image: require('../assets/imgs/icon_about_search.png') },
    { name: 'Thêm mới bảng số', id: 2, des: ["Trực tiếp thêm mới bảng số sim ngay trên ứng dụng với chỉ 3 bước"], image: require('../assets/imgs/icon_about_add.png') },
    { name: 'Cập nhật chiết khấu', id: 3, des: ["Chỉnh sửa mật khẩu dễ dàng cho cả bảng số hoặc cho từng khoảng giá"], image: require('../assets/imgs/icon_about_discount.png') },
    { name: 'Đồng bộ bảng số', id: 4, des: ["Bảng số sẽ ngay lập tức được đồng bộ lên hơn 1000+ web sim"], image: require('../assets/imgs/icon_about_synchrous.png') },
    // { name: 'Check Sim', id: 5, des: ["Không cần phải gọi điện, nhắn tin cho đại lý mà vẫn kiểm tra được sim còn hay đã bán"], image: require('../assets/imgs/icon_letter.png') },
];

const AboutScreen = ({ navigation }) => {
    return (
        <SafeAreaView>
            <View className="" >
                <Banner></Banner>
                <View testID="Body">
                    <ScrollView>
                        <MasonryList
                            data={aboutDatas}
                            numColumns={1}
                            renderItem={({ item }) => (
                                <AboutCard data={item} />
                            )}
                            columnWrapperStyle={{ justifyContent: 'space-between' }}
                            contentContainerStyle={{ paddingVertical: 10 }}
                        />

                    </ScrollView>
                </View>
            </View>
        </SafeAreaView>
    );
}
const AboutCard = (prop) => {
    return (
        <View className="flex-row justifty-center items-center bg-white mt-1 px-5">
            <View className="mx-2 justify-center items-center" testID="left" style={{height:100 }}>
                <Image source={prop.data.image} style={{ width: 70, height: 70 }} resizeMode='contain' />
            </View>
            <View className="" testID="right">
                <View className = "">
                    <Text className="font-bold" style={{ fontSize: 15 }}>{prop.data.name}</Text>
                </View>

   

                <View className = "" style = {{width:250}}>
                    {prop.data.des.map((desItem, index) => (
                        <View key={index}>
                            <Text>{desItem}</Text>
                        </View>
                    ))}
                </View>

            </View>
        </View>
    );
}
export default AboutScreen;