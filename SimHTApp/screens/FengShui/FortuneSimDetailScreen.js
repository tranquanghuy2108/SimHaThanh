import React, { useContext } from 'react';
import { Text, Image, View, StyleSheet, SafeAreaView, ScrollView } from 'react-native';
import { argonTheme } from '../../constants';
import { FengShuiContext } from '../../context/FengShuiContext';

import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize
} from "react-native-responsive-dimensions";

const FortuneSimDetailScreen = ({ navigation }) => {
  const { fortuneData } = useContext(FengShuiContext);
  const TakeFortuneCardImg = (id) => {
    var imgURL = null;
    switch (id) {
      case 1:
        imgURL = require('./../../assets/FortuneCard/tuongque-1.png');
        break;
      case 2:
        imgURL = require('./../../assets/FortuneCard/tuongque-2.png');
        break;
      case 3:
        imgURL = require('./../../assets/FortuneCard/tuongque-3.png');
        break;
      case 4:
        imgURL = require('./../../assets/FortuneCard/tuongque-4.png');
        break;
      case 5:
        imgURL = require('./../../assets/FortuneCard/tuongque-5.png');
        break;
      case 6:
        imgURL = require('./../../assets/FortuneCard/tuongque-6.png');
        break;
      case 7:
        imgURL = require('./../../assets/FortuneCard/tuongque-7.png');
        break;
      case 8:
        imgURL = require('./../../assets/FortuneCard/tuongque-8.png');
        break;
      case 9:
        imgURL = require('./../../assets/FortuneCard/tuongque-9.png');
        break;
      case 10:
        imgURL = require('./../../assets/FortuneCard/tuongque-10.png');
        break;
      case 11:
        imgURL = require('./../../assets/FortuneCard/tuongque-11.png');
        break;
      case 12:
        imgURL = require('./../../assets/FortuneCard/tuongque-12.png');
        break;
      case 13:
        imgURL = require('./../../assets/FortuneCard/tuongque-13.png');
        break;
      case 14:
        imgURL = require('./../../assets/FortuneCard/tuongque-14.png');
        break;
      case 15:
        imgURL = require('./../../assets/FortuneCard/tuongque-15.png');
        break;
      case 16:
        imgURL = require('./../../assets/FortuneCard/tuongque-16.png');
        break;
      case 17:
        imgURL = require('./../../assets/FortuneCard/tuongque-17.png');
        break;
      case 18:
        imgURL = require('./../../assets/FortuneCard/tuongque-18.png');
        break;
      case 19:
        imgURL = require('./../../assets/FortuneCard/tuongque-19.png');
        break;
      case 21:
        imgURL = require('./../../assets/FortuneCard/tuongque-21.png');
        break;
      case 22:
        imgURL = require('./../../assets/FortuneCard/tuongque-22.png');
        break;
      case 23:
        imgURL = require('./../../assets/FortuneCard/tuongque-23.png');
        break;
      case 24:
        imgURL = require('./../../assets/FortuneCard/tuongque-24.png');
        break;
      case 25:
        imgURL = require('./../../assets/FortuneCard/tuongque-25.png');
        break;
      case 26:
        imgURL = require('./../../assets/FortuneCard/tuongque-26.png');
        break;
      case 27:
        imgURL = require('./../../assets/FortuneCard/tuongque-27.png');
        break;
      case 28:
        imgURL = require('./../../assets/FortuneCard/tuongque-28.png');
        break;
      case 29:
        imgURL = require('./../../assets/FortuneCard/tuongque-29.png');
        break;
      case 30:
        imgURL = require('./../../assets/FortuneCard/tuongque-30.png');
        break;
      case 31:
        imgURL = require('./../../assets/FortuneCard/tuongque-31.png');
        break;
      case 32:
        imgURL = require('./../../assets/FortuneCard/tuongque-32.png');
        break;
      case 33:
        imgURL = require('./../../assets/FortuneCard/tuongque-33.png');
        break;
      case 34:
        imgURL = require('./../../assets/FortuneCard/tuongque-34.png');
        break;
      case 35:
        imgURL = require('./../../assets/FortuneCard/tuongque-35.png');
        break;
      case 36:
        imgURL = require('./../../assets/FortuneCard/tuongque-36.png');
        break;
      case 37:
        imgURL = require('./../../assets/FortuneCard/tuongque-37.png');
        break;
      case 38:
        imgURL = require('./../../assets/FortuneCard/tuongque-38.png');
        break;
      // case 39:
      //   imgURL = require('./../../assets/FortuneCard/tuongque-39.png');
      //   break;
      case 40:
        imgURL = require('./../../assets/FortuneCard/tuongque-40.png');
        break;
      case 41:
        imgURL = require('./../../assets/FortuneCard/tuongque-42.png');
        break;
      case 43:
        imgURL = require('./../../assets/FortuneCard/tuongque-43.png');
        break;
      case 44:
        imgURL = require('./../../assets/FortuneCard/tuongque-44.png');
        break;
      case 45:
        imgURL = require('./../../assets/FortuneCard/tuongque-45.png');
        break;
      case 46:
        imgURL = require('./../../assets/FortuneCard/tuongque-46.png');
        break;
      case 47:
        imgURL = require('./../../assets/FortuneCard/tuongque-47.png');
        break;
      case 48:
        imgURL = require('./../../assets/FortuneCard/tuongque-48.png');
        break;
      case 49:
        imgURL = require('./../../assets/FortuneCard/tuongque-49.png');
        break;
      case 50:
        imgURL = require('./../../assets/FortuneCard/tuongque-50.png');
        break;
      case 51:
        imgURL = require('./../../assets/FortuneCard/tuongque-51.png');
        break;
      case 52:
        imgURL = require('./../../assets/FortuneCard/tuongque-52.png');
        break;
      case 53:
        imgURL = require('./../../assets/FortuneCard/tuongque-53.png');
        break;
      case 54:
        imgURL = require('./../../assets/FortuneCard/tuongque-54.png');
        break;
      case 55:
        imgURL = require('./../../assets/FortuneCard/tuongque-55.png');
        break;
      case 56:
        imgURL = require('./../../assets/FortuneCard/tuongque-56.png');
        break;
      case 57:
        imgURL = require('./../../assets/FortuneCard/tuongque-57.png');
        break;
      case 58:
        imgURL = require('./../../assets/FortuneCard/tuongque-58.png');
        break;
      case 59:
        imgURL = require('./../../assets/FortuneCard/tuongque-59.png');
        break;
      case 60:
        imgURL = require('./../../assets/FortuneCard/tuongque-60.png');
        break;
      case 61:
        imgURL = require('./../../assets/FortuneCard/tuongque-61.png');
        break;
      case 62:
        imgURL = require('./../../assets/FortuneCard/tuongque-62.png');
        break;
      case 63:
        imgURL = require('./../../assets/FortuneCard/tuongque-63.png');
        break;
      case 64:
        imgURL = require('./../../assets/FortuneCard/tuongque-64.png');
        break;

    }
    return imgURL;
  }

  const GroupSeparateNum = (separateNumArray) => {
    const result = separateNumArray.join("");
    return result;
  }

  const TotalPointCaculate = (pointAmDuong, pointNguHanh, pointBatQuai, poingCuuTinhDo, pointQuanNiemDanGian) => {
    var totalPoint = pointAmDuong + pointNguHanh + pointBatQuai + poingCuuTinhDo + pointQuanNiemDanGian;
    if (totalPoint > 10) {
      totalPoint = 10;
    }
    return totalPoint;
  }
  return (

    <SafeAreaView>
      {fortuneData ? (
        <ScrollView style={styles.container}>



          <View className="mx-2">


            <View>
              <Text>
                <Text style={styles.texHeader}>Kết quả phong thủy sim: </Text>
                <Text style={styles.findSim}>{GroupSeparateNum(fortuneData.nguHanhSim.numberOfSim)} </Text>
              </Text>

              <Text style={styles.textParentContent}>
                Con người là tổng hoà các mối quan hệ, trong đó chịu sự ảnh hưởng chi phối của thiên nhiên và xã hội. Người xưa coi con người là một vũ trụ thu nhỏ, là 1 trong 3 yếu tố tam Tài là Thiên - Địa - Nhân. Con người đóng vai trò trung tâm của vũ trụ, trời và đất. Do vậy xét những con số tốt xấu phải theo các khía cạnh Âm Dương, Ngũ Hành, Thiên Thời, Quẻ dịch và cả Quan niệm dân gian nữa.
              </Text>

            </View>

            {/* OVerview */}
            <View testID="OverView" style={styles.overview}>

              <Image source={require('./../../assets/FortuneCard/zodiac12.png')} style={{ width: "100%", height: "100%", position: "absolute", top: 10 }} resizeMode='contain' />
              <View testID="FirstRow" className="flex-row">
                <View testID="Left" >
                  <Image source={require('../../assets/imgs/icon_user.png')} style={{ width: responsiveWidth(10), height: responsiveWidth(10), top: 7 }} resizeMode='contain' />
                </View>
                <View testID="right" className="flex-1">

                  <Text >
                    <Text style={styles.texHeader}>Thân chủ: </Text>
                    <Text style={styles.textContent}>{`sinh ngày ( ${fortuneData.lunarBirthDay} Âm lịch)`}</Text>

                  </Text>


                  <Text >
                    <Text style={styles.texHeader}>Năm can chi: </Text>
                    <Text style={styles.textContent}>{`${fortuneData.menhchu.canChi}`}</Text>
                  </Text>
                </View>

              </View>

              {/* Mệnh Niên */}
              <View testID="NextRow" className="flex-1">

                <Text >
                  <Text style={styles.texHeader}>Mệnh Cung Sinh: </Text>
                  <Text style={styles.textContent}>{`${fortuneData.menhchu.cungSinh1} - ${fortuneData.menhchu.cungSinh2}`}</Text>
                </Text>
              </View>

              {/* Mệnh quái */}
              <View testID="NextRow" className="flex-1">

                <Text >
                  <Text style={styles.texHeader}>Ngũ hành: </Text>
                  <Text style={styles.textContent}>{`${fortuneData.menhchu.nguHanh}`}</Text>
                </Text>
              </View>
              {/* Mệnh Niên */}
              <View testID="NextRow" className="flex-1">

                <Text >
                  <Text style={styles.texHeader}>Mệnh Cung Phi: </Text>
                  <Text style={styles.textContent}>{`${fortuneData.menhchu.cungPhi1} - ${fortuneData.menhchu.cungPhi2}`}</Text>
                </Text>
              </View>

              {/* Cung mệnh */}
              <View testID="NextRow" className="flex-1">

                <Text >
                  <Text style={styles.texHeader}>Con Giáp: </Text>
                  <Text style={styles.textContent}>{`${fortuneData.menhchu.conGiap}`}</Text>
                </Text>
              </View>


              {/* Bát tự */}

              {/* Mệnh */}

            </View>

            {/*1.Mệnh chủ */}
            {/* Âm dương tương phối */}

            <View className=''>
              <Text style={styles.texHeader}>1. ÂM DƯƠNG TƯƠNG PHỐI</Text>
              <Text style={styles.textContent}>
                Âm dương (chữ Hán 陰陽) là hai khái niệm để chỉ hai thực thể đối lập ban đầu tạo nên toàn bộ vũ trụ. Trong mỗi vật thể, sự việc đều luôn tồn tại hai trạng thái Âm và Dương, mà nếu thiên lệch về trạng thái nào quá cũng đều không tốt. Âm dương là hai khái niệm để chỉ hai thực thể đối lập ban đầu tạo nên toàn bộ vũ trụ. Ý niệm âm dương đã ăn sâu trong tâm thức người Việt từ ngàn xưa và được phản chiếu rất rõ nét trong ngôn ngữ nói chung và các con số nói riêng. Người xưa quan niệm rằng các số chẵn mang vận âm, các số lẻ mang vận dương.
              </Text>
              {/* <ScrollView
                horizontal
              > */}
              <View>
                <View className="flex-row">
                  {
                    fortuneData.nguHanhSim.numberOfSim.map(number => {
                      return (
                        <View style={styles.cellTable}>
                          <Text style={styles.textContent}>{number}</Text>
                        </View>
                      )
                    })
                  }
                </View>

                <View className="flex-row">
                  {
                    fortuneData.amDuongTuongPhoi.amDuongTuongPhoi.map(sign => {
                      return (
                        <View style={styles.cellTable}>
                          <Text style={styles.textContent}>{sign}</Text>
                        </View>
                      )
                    })
                  }
                </View>
              </View>
              {/* </ScrollView> */}
              <Text style={styles.textContent}>
                {`Dãy số có ${fortuneData.amDuongTuongPhoi.soAmAmount} số mang vận âm, ${fortuneData.amDuongTuongPhoi.soDuongAmount} số mang vận dương`}
              </Text>
              <Text style={styles.textContent}>
                {`Dãy số mang vận ${fortuneData.amDuongTuongPhoi.vanSo}`}
              </Text>
            </View>

            {/* NGŨ HÀNH */}
            <View className=''>
              <Text style={styles.texHeader}>2. NGŨ HÀNH TƯƠNG PHỐI</Text>
              <Text style={styles.textContent}>
                Theo triết học cổ Trung Hoa, tất cả vạn vật đều phát sinh từ năm nguyên tố cơ bản và luôn luôn trải qua năm trạng thái được gọi là: Mộc, Hỏa, Thổ, Kim và Thủy. Năm trạng thái này, gọi là Ngũ hành (五行), không phải là vật chất như cách hiểu đơn giản mà đúng hơn là cách quy ước của người Trung Hoa cổ đại để xem xét mối tương tác và quan hệ của vạn vật. Ngũ hành quan hệ với nhau qua hai quan hệ tương sinh và tương khắc. Số sử dụng cho người cần tạo lập mối quan hệ tương sinh, tránh tương khắc.
              </Text>
              <Image
                source={require("../../assets/FortuneCard/nguhanhtuongsinh.png")}
                style={{ width: '100%', height: responsiveHeight(19) }}
                resizeMode={"contain"}
              />
              {/* Thân chủ */}
              <Text style={styles.texHeader}>2.1. Thân chủ</Text>
              <Text style={styles.textContent}>
                {`Hành của bản mệnh: ${fortuneData.menhchu.nguHanh} (Năm sinh: ${fortuneData.menhchu.canChi})`}
              </Text>
              <Text style={styles.textContent}>
                {`Hành của số sim: ${fortuneData.nguHanhSim.nguHanhSim}`}
              </Text>
              <Text style={styles.textContent}>
                {`${fortuneData.nguHanhSim.simSinhKhac}`}
              </Text>
              {/* Chuỗi Số */}
              <Text style={styles.texHeader}>2.2. Chuối số</Text>
              {/* <ScrollView
                horizontal
              > */}
              <View>

                <View className="flex-row">
                  {
                    fortuneData.nguHanhSim.numberOfSim.map(number => {
                      return (
                        <View style={styles.cellTable}>
                          <Text style={styles.cellTableTxt}>{number}</Text>
                        </View>
                      )
                    })
                  }
                </View>

                <View className="flex-row">
                  {
                    fortuneData.nguHanhSim.nguHanhOfnumber.map(sign => {
                      return (
                        <View style={styles.cellTable}>
                          <Text style={styles.cellTableTxt}>{sign}</Text>
                        </View>
                      )
                    })
                  }
                </View>

                <View className="flex-row">
                  {
                    fortuneData.nguHanhSim.nguHanhSinhKhac.map(sign => {
                      return (
                        <View style={styles.cellTable}>
                          <Text style={styles.cellTableTxt}>{sign}</Text>
                        </View>
                      )
                    })
                  }
                </View>
              </View>
              {/* </ScrollView> */}
            </View>

            {/* THIÊN THỜI */}
            <View className=''>
              <Text style={styles.texHeader}>3.THIÊN THỜI</Text>
              <Text style={styles.textContent}>
                Từ năm 2024 – 2043 chúng ta bước vào vận 9 hạ nguyên do sao Cửu Tử làm chủ quản. Đây là sao nửa hung nửa cát nhưng do nó đang chuẩn bị tiến vào đắc vị nên sẽ mang lại may mắn. Tiến hành an cửu tinh trên sơn bàn và so sánh với số đang xét, ta thấy: Số nhận được vận khí tốt từ sao Bát Bạch, được về Thiên Thời.
              </Text>

              <Image
                source={require('./../../assets/FortuneCard/sonban.png')}
                style={{ width: '100%', height: responsiveHeight(13) }}
                resizeMode={"contain"}
              />

            </View>
            {/* PHỐI QUẺ DỊCH BÁT QUÁI */}
            <View className=''>
              <Text style={styles.texHeader}>4.PHỐI QUẺ DỊCH BÁT QUÁI</Text>
              <Text style={styles.texHeader}>
                {
                  `Ý nghĩa quẻ ${fortuneData.queBatQuai.queChu.queName}`
                }

              </Text>
              <Text style={styles.texHeader} >Tượng quẻ:</Text>
              <Image
                source={TakeFortuneCardImg(fortuneData.queBatQuai.queChu.queSo)}
                style={{ width: '100%', height: responsiveHeight(13) }}
                resizeMode={"contain"}
              />
              {/* Lời Kinh */}
              <Text style={{}}>
                <Text style={styles.texHeader} >Lời Kinh: </Text>
                <Text style={styles.textContent}>{fortuneData.queBatQuai.queChu.loiKinh}</Text>
              </Text>
              {/* Dịch Âm */}
              <Text>
                <Text style={styles.texHeader} >Dịch âm: </Text>
                <Text style={styles.textContent}>{fortuneData.queBatQuai.queChu.dichAm}</Text>
              </Text>
              {/* Dịch Nghĩa */}
              <Text>
                <Text style={styles.texHeader} >Dịch nghĩa: </Text>
                <Text style={styles.textContent}>{fortuneData.queBatQuai.queChu.dichNghia}</Text>
              </Text>

              {/* Giải nghĩa */}
              <Text style={styles.texHeader} >Giải Nghĩa</Text>
              <Text style={styles.textContent}>{fortuneData.queBatQuai.queChu.giaiNghia}</Text>

              {/* Loại quẻ */}
              <Text>
                <Text style={styles.texHeader} >Loại Quẻ: </Text>
                <Text style={styles.textContent}>{fortuneData.queBatQuai.queChu.loaiQue}</Text>
              </Text>
            </View>

            {/* QUAN NIỆM DÂN GIAN */}
            <View className=''>
              <Text style={styles.texHeader}>5.QUAN NIỆM DÂN GIAN</Text>
              <Text style={styles.textContent}>
                Quan niệm dân gian là những kinh nghiệm được truyền miệng và lưu truyền nhiều đời trong dân gian trong việc đánh giá tốt xấu của một dãy số. Ví như các số có đuôi 68,86 phát âm trong tiếng Hán hơi giống với Lộc Phát - Phát Lộc, nên quan niệm dân gian cho là tốt. Hay các số có sự lặp lại nhiều thì dễ nhớ hơn, và quan niệm dân gian cũng cho là đẹp hơn.

              </Text>


              <Text style={styles.emphasizTxt}>
                {
                  `Tổng nút: ${fortuneData.quanNiemDanGian.soNut}`
                }
              </Text>
              <Text style={[styles.textContent, { color: argonTheme.COLORS.ERROR, fontStyle: 'italic' }]}>
                {
                  `(Quý khách chú ý: Thang điểm chỉ mang tính chất kham khảo)`
                }
              </Text>
              <Text style={[styles.textContent, { fontStyle: 'italic' }]}>
                {
                  `Quý khách cần đọc kỹ các chi tiết để xem số có hợp với mình không`
                }

              </Text>
              <View style={styles.point}>
                <Text style={styles.pointTxt}>{`Tổng điểm: ${TotalPointCaculate(fortuneData.amDuongTuongPhoi.point, fortuneData.nguHanhSim.point, fortuneData.queBatQuai.point, fortuneData.pointCuuTinhDo, fortuneData.quanNiemDanGian.point)}/10`}</Text>
              </View>
            </View>


            {/* CẢI VẬN BỔ KHUYẾT */}
            {/* <View className=''>
              <Text style={styles.texHeader}>THAM KHẢO SỐ SIM TƯƠNG SINH CHO NGŨ HÀNH CỦA BẠN</Text>
              <View style={styles.improveSim}>
                <Text>
                  <Text style={styles.pointTxt}>09182663339</Text>
                  <Text style={styles.pointTxt}> (Điểm: 10/10)</Text>
                </Text>
                <Text>
                  <Text style={styles.pointTxt}>3.500.000 Đ</Text>
                </Text>
                <View style={styles.bottomSim}>
                  <TouchableOpacity style={styles.buttonSim}>
                    <Text>Xem luận giải</Text>
                  </TouchableOpacity>
                  <TouchableOpacity style={styles.buttonSim}>
                    <Text>Mua ngay</Text>
                  </TouchableOpacity>
                </View>
              </View>
            </View> */}
          </View>

        </ScrollView>
      ) : (
        <View className="items-center mt-5">
          <Text className="font-bold">
            Không có dữ liệu!
          </Text>
        </View>
      )
      }

    </SafeAreaView>
  )
}
const styles = StyleSheet.create({
  container: {
    backgroundColor: 'white',
  },
  overview: {
    height: 'auto',
    borderRadius: 3,
    padding: 10,
    margin: 4,
    shadowOpacity: .1,
    shadowRadius: 3,
    elevation: 1,
    shadowColor: 'black',
  },
  textRow: {
    textAlign: "auto",
  },
  texHeader: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.2),
  },
  findSim: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.4),
    color: argonTheme.COLORS.ERROR,
  },
  emphasizTxt: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.1),
    marginLeft: 5,
    marginRight: 5,
  },
  textContent: {
    textAlign: "justify",
    marginLeft: 5,
    marginRight: 5,
    fontSize: responsiveFontSize(2.1)
  },
  textParentContent: {
    textAlign: "justify",
    fontSize: responsiveFontSize(2.1)
  },
  cellTableTxt: {
    textAlign: "justify",
    fontSize: responsiveFontSize(1.9)
  },
  cellTable: {
    borderWidth: 1,
    borderColor: 'black',
    flex: 1,
    alignItems: "center",
    width: 100,
  },
  point: {
    alignItems: "center",
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "auto",
    margin: 1,
    marginTop: 20,
    marginBottom: 20,
    padding: 15,
    borderRadius: 10

  },
  pointTxt: {
    color: "white",
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.2)
  },
  improveSim: {
    alignItems: "center",
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "auto",
    margin: 1,
    padding: 15,
    borderRadius: 10
  },
  bottomSim: {
    flexDirection: "row",
    width: "100%",
    alignItems: "center",
    padding: 5,
    margin: 5,


    justifyContent: "center",
  },
  buttonSim: {
    backgroundColor: "white",
    padding: 5,
    margin: 5,
    borderRadius: 5,
  }
});

export default FortuneSimDetailScreen;