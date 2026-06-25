import { React, useState, useRef, useEffect } from 'react';
import { Dimensions, ScrollView, View, Image } from "react-native";
import { responsiveHeight, responsiveWidth } from 'react-native-responsive-dimensions';

const { width,height } = Dimensions.get('window');
const Banner = () => {
    const scrollViewRef = useRef(null);
    const [currentIndex, setCurrentIndex] = useState(0);

    const data = [
        { id: 1, image: require('../assets/imgs/banner.png') },
        { id: 2, image: require('../assets/imgs/banner.png') },
        { id: 3, image: require('../assets/imgs/banner.png') },
    ];

    useEffect(() => {
        const timer = setInterval(() => {
            const nextIndex = (currentIndex + 1) % data.length;
            scrollViewRef.current.scrollTo({ x: nextIndex * width, y: 0, animated: true });
            setCurrentIndex(nextIndex);
        }, 2000);

        return () => {
            clearInterval(timer);
        };
    }, [currentIndex]);

    const handleScroll = (event) => {
        const offsetX = event.nativeEvent.contentOffset.x;
        const newIndex = Math.round(offsetX / width);
        setCurrentIndex(newIndex);
    };

    return (
        <View>
            <ScrollView
                ref={scrollViewRef}
                horizontal
                pagingEnabled
                showsHorizontalScrollIndicator={false}
                onScroll={handleScroll}
                scrollEventThrottle={16}
            >
                {data.map((item) => (
                    <Image key={item.id} source={item.image} style={{ resizeMode:"stretch",width:responsiveWidth(100),height: responsiveHeight(10)}} />
                ))}
            </ScrollView>
        </View>
    );
}
export default Banner;