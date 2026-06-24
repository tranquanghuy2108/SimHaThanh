using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Commons.Models;
using CsvHelper;
using ExcelDataReader;

namespace Commons.Helper
{
    public static class FileHelper
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="phoneNum"></param>
        /// <param name="phoneNumNew"></param>
        /// <returns></returns>
        public static List<string> CheckFormatTypeOfSim(string phoneNum, out string phoneNumNew)
        {
            List<string> listTypeOfSims = new List<string>();
            phoneNum = phoneNum.Replace(".", "").Replace("-", "").Replace(" ", "");
            phoneNumNew = phoneNum;
            //
            if (phoneNum.Length >= 9)
            {
                var phoneNumber = phoneNum.Substring(phoneNum.Length - 9);
                var numElement = phoneNumber.ToCharArray();
                string el1 = numElement[0].ToString();
                string el2 = numElement[1].ToString();
                string el3 = numElement[2].ToString();
                string el4 = numElement[3].ToString();
                string el5 = numElement[4].ToString();
                string el6 = numElement[5].ToString();
                string el7 = numElement[6].ToString();
                string el8 = numElement[7].ToString();
                string el9 = numElement[8].ToString();
                phoneNumNew = FormatPhoneNumber(phoneNumber, Enums.FormatPhoneNumber.F0XXX_XXX_XXX);
                //
                if (numElement.Length == 9)
                {
                    // Ngũ quý
                    if (el5 == el6 && el6 == el7 && el7 == el8 && el8 == el9)
                    {
                        listTypeOfSims.Add(".AAAAA");
                        phoneNumNew = FormatPhoneNumber(
                            phoneNumber,
                            Enums.FormatPhoneNumber.F0XXX_X_XXXXX
                        );
                    }
                    // Tứ quý
                    else if (el6 == el7 && el7 == el8 && el8 == el9)
                    {
                        listTypeOfSims.Add(".AAAA");
                        phoneNumNew = FormatPhoneNumber(
                            phoneNumber,
                            Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                        );
                    }
                    // Tam hoa kép
                    else if (el4 == el5 && el5 == el6 && el7 == el8 && el8 == el9)
                    {
                        listTypeOfSims.Add("AAA.BBB");
                    }
                    // Tam hoa
                    else if (el7 == el8 && el8 == el9)
                    {
                        listTypeOfSims.Add(".AAA");
                    }
                    else
                    {
                        // Sim Taxi
                        // AB.AB.AB
                        if ((el4 + el5) == (el6 + el7) && (el6 + el7) == (el8 + el9))
                        {
                            listTypeOfSims.Add("AB.AB.AB");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // BAA.BAA
                        if ((el4 + el5 + el6) == (el7 + el8 + el9) && (el8 == el9))
                        {
                            listTypeOfSims.Add("BAA.BAA");
                        }
                        // AAB.AAB
                        if ((el4 + el5 + el6) == (el7 + el8 + el9) && el4 == el5)
                        {
                            listTypeOfSims.Add("AAB.AAB");
                        }
                        // AA.BB.AA
                        if (el4 == el5 && el6 == el7 && el8 == el9 && (el4 == el8))
                        {
                            listTypeOfSims.Add("AA.BB.AA");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // AA.BB.CC
                        if (el4 == el5 && el6 == el7 && el8 == el9)
                        {
                            listTypeOfSims.Add("AA.BB.CC");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }

                        // AB.AB.AB.xy
                        if (el2 + el3 == el4 + el5 && el4 + el5 == el6 + el7)
                        {
                            listTypeOfSims.Add("AB.AB.AB.xy");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0X_XX_XX_XX_XX
                            );
                        }

                        // xyz.xyz
                        if ((el4 + el5 + el6) == (el7 + el8 + el9))
                        {
                            listTypeOfSims.Add("xyz.xyz");
                        }
                        //Tiến đơn 5
                        // ABCDE
                        if (
                            (Int32.Parse(el5) + 1 == Int32.Parse(el6))
                            && (Int32.Parse(el6) + 1 == Int32.Parse(el7))
                            && (Int32.Parse(el7) + 1 == Int32.Parse(el8))
                            && (Int32.Parse(el8) + 1 == Int32.Parse(el9))
                        )
                        {
                            listTypeOfSims.Add(".ABCDE");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_X_XXXXX
                            );
                        }
                        // Tiến đôi 4
                        // ABCD.ABCD
                        if (
                            (el2 + el3 + el4 + el5) == (el6 + el7 + el8 + el9)
                            && Int32.Parse(el5) == Int32.Parse(el4) + 1
                            && Int32.Parse(el4) == Int32.Parse(el3) + 1
                            && Int32.Parse(el3) == Int32.Parse(el2) + 1
                        )
                        {
                            listTypeOfSims.Add("ABCD.ABCD");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0X_XXXX_XXXX
                            );
                        }
                        // Tiến đơn 4
                        else if (
                            Int32.Parse(el9) == Int32.Parse(el8) + 1
                            && Int32.Parse(el8) == Int32.Parse(el7) + 1
                            && Int32.Parse(el7) == Int32.Parse(el6) + 1
                        )
                        {
                            listTypeOfSims.Add(".ABCD");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                            );
                        }
                        //Tiến đôi 3
                        // ABC.ABC
                        if (
                            (el4 + el5 + el6) == (el7 + el8 + el9)
                            && (Int32.Parse(el8) == Int32.Parse(el7) + 1)
                            && (Int32.Parse(el9) == Int32.Parse(el8) + 1)
                        )
                        {
                            listTypeOfSims.Add("ABC.ABC");
                        }
                        // Tiến đơn 3
                        // ABC
                        else if (
                            (Int32.Parse(el7) + 1 == Int32.Parse(el8))
                            && (Int32.Parse(el8) + 1 == Int32.Parse(el9))
                        )
                        {
                            listTypeOfSims.Add("ABC");
                        }

                        // AAAA.b
                        if (el5 == el6 && el6 == el7 && el7 == el8)
                        {
                            listTypeOfSims.Add(".AAAA.");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_X_XXXX_X
                            );
                        }
                        // AAAA.bx
                        if (el4 == el5 && el5 == el6 && el6 == el7)
                        {
                            listTypeOfSims.Add(".AAAA.");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                            );
                        }
                        // AAAA.bxx
                        if (el3 == el4 && el4 == el5 && el5 == el6)
                        {
                            listTypeOfSims.Add(".AAAA.");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XX_XXXX_XXX
                            );
                        }
                        // AAAA.bxxx
                        if (el2 == el3 && el3 == el4 && el4 == el5)
                        {
                            listTypeOfSims.Add(".AAAA.");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0X_XXXX_XXXX
                            );
                        }
                        // AAAA.bxxxx
                        if (el1 == el2 && el2 == el3 && el3 == el4)
                        {
                            listTypeOfSims.Add(".AAAA.");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXXX_XXXXX
                            );
                        }
                        // AAA.b
                        if (el6 == el7 && el7 == el8)
                        {
                            listTypeOfSims.Add("AAA.b");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XXX_X
                            );
                        }
                        // AAA.bx
                        if (el5 == el6 && el6 == el7)
                        {
                            listTypeOfSims.Add("AAA.bx");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXXX_XXX_XX
                            );
                        }
                        // AAA.bxx
                        if (el4 == el5 && el5 == el6)
                        {
                            listTypeOfSims.Add("AAA.bxx");
                        }
                        // AbA.AcA
                        if (el4 == el6 && el6 == el7 && el7 == el9)
                        {
                            listTypeOfSims.Add("AbA.AcA");
                        }
                        // ABB.CBB
                        if (el5 == el6 && el6 == el8 && el8 == el9)
                        {
                            listTypeOfSims.Add("ABB.CBB");
                        }
                        // AAB.AAC
                        if (el4 == el5 && el5 == el7 && el7 == el8)
                        {
                            listTypeOfSims.Add("AAB.AAC");
                        }
                        // ABC.ABD
                        if (el4 + el5 == el7 + el8 && (el6 + 1 == el9))
                        {
                            listTypeOfSims.Add("ABC.ABD");
                        }
                        // ABAB
                        if (el6 + el7 == el8 + el9)
                        {
                            listTypeOfSims.Add("ABAB");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                            );
                        }
                        // ABBA
                        if (el6 + el7 == el9 + el8)
                        {
                            listTypeOfSims.Add("ABBA");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                            );
                        }
                        // ABBA.CDDC
                        if (el2 + el3 == el5 + el4 && el6 + el7 == el9 + el8)
                        {
                            listTypeOfSims.Add("ABBA.CDDC");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0X_XXXX_XXXX
                            );
                        }
                        // AABB
                        if (el6 == el7 && el8 == el9)
                        {
                            listTypeOfSims.Add("AABB");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                            );
                        }
                        // AB.CB.DB
                        if (el5 == el7 && el7 == el9)
                        {
                            listTypeOfSims.Add("AB.CB.DB");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // AB.AC.AD
                        if (el4 == el6 && el6 == el8)
                        {
                            listTypeOfSims.Add("AB.AC.AD");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // AAB.CAA
                        if (el4 + el5 == el8 + el9 && el4 == el8)
                        {
                            listTypeOfSims.Add("AAB.CAA");
                        }
                        // xyzzyx
                        if (el4 + el5 + el6 == el9 + el8 + el7)
                        {
                            listTypeOfSims.Add("xyz.zyx");
                        }
                        // 19
                        if (el6 + el7 == "19")
                        {
                            listTypeOfSims.Add("19bx");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                            );
                        }
                        // AB.CD.AB
                        if (el4 + el5 == el8 + el9)
                        {
                            listTypeOfSims.Add("AB.CD.AB");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // AB.AB.CD
                        if (el4 + el5 == el6 + el7)
                        {
                            listTypeOfSims.Add("AB.AB.CD");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // AAB CCD
                        if (el4 == el5 && el7 == el8)
                        {
                            listTypeOfSims.Add("AAB.CCD");
                        }
                        // ABA
                        if (el7 == el9)
                        {
                            listTypeOfSims.Add(".ABA");
                        }
                        // AB AD
                        if (el6 == el8)
                        {
                            listTypeOfSims.Add("AB.AD");
                            phoneNumNew = (
                                "0"
                                + el1
                                + el2
                                + el3
                                + "."
                                + el4
                                + el5
                                + "."
                                + el6
                                + el7
                                + "."
                                + el8
                                + el9
                            ).ToString();
                        }
                        // xA.yA.zA
                        if (el5 == el7 && el7 == el9)
                        {
                            listTypeOfSims.Add("xA.yA.zA");
                            phoneNumNew = FormatPhoneNumber(
                                phoneNumber,
                                Enums.FormatPhoneNumber.F0XXX_XX_XX_XX
                            );
                        }
                        // ABB CDD
                        if (el5 == el6 && el8 == el9)
                        {
                            listTypeOfSims.Add("ABB.CDD");
                        }
                        // ADB.ACB
                        if (el4 == el7 && el6 == el9)
                        {
                            listTypeOfSims.Add("ADB.ACB");
                        }
                        // AAB.CDD
                        if (el4 == el5 && el8 == el9)
                        {
                            listTypeOfSims.Add("AAB.CDD");
                        }
                        // ABA.CDD
                        if (el4 == el6 && el8 == el9)
                        {
                            listTypeOfSims.Add("ABA.CDD");
                        }
                        // ABA.CCD
                        if (el4 == el6 && el8 == el7)
                        {
                            listTypeOfSims.Add("ABA.CCD");
                        }
                        // ACB.DCB
                        if (el5 + el6 == el8 + el9)
                        {
                            listTypeOfSims.Add("ACB.DCB");
                        }
                        // ABAB.xxx
                        if (el3 + el4 == el5 + el6)
                        {
                            listTypeOfSims.Add("ABAB.xxx");
                        }
                        // AABB.Cx
                        if (el4 == el5 && el6 == el7)
                        {
                            listTypeOfSims.Add("AABB.Cx");
                            phoneNumNew = (
                                "0"
                                + el1
                                + el2
                                + el3
                                + "."
                                + el4
                                + el5
                                + el6
                                + el7
                                + "."
                                + el8
                                + el9
                            ).ToString();
                        }
                        // AABB.CxD
                        if (el3 == el4 && el5 == el6)
                        {
                            listTypeOfSims.Add("AABB.CxD");
                            phoneNumNew = (
                                "0"
                                + el1
                                + el2
                                + "."
                                + el3
                                + el4
                                + el5
                                + el6
                                + "."
                                + el7
                                + el8
                                + el9
                            ).ToString();
                        }
                        // BCD.EAA
                        if (el4 + 1 == el5 && el5 + 1 == el6 && el8 == el9)
                        {
                            listTypeOfSims.Add("BCD.EAA");
                        }
                        // xAABBx
                        if (el5 == el6 && el7 == el8)
                        {
                            listTypeOfSims.Add("xAABBx");
                            phoneNumNew = (
                                "0"
                                + el1
                                + el2
                                + el3
                                + el4
                                + "."
                                + el5
                                + el6
                                + el7
                                + el8
                                + "."
                                + el9
                            ).ToString();
                        }
                        // AAB.CDE
                        if (el4 == el5)
                        {
                            listTypeOfSims.Add("AAB.CDE");
                        }
                        // xAA.BCD
                        if (el5 == el6)
                        {
                            listTypeOfSims.Add("xAA.BCD");
                        }
                        // BCD.AAx
                        if (el7 == el8)
                        {
                            listTypeOfSims.Add("BCD.AAx");
                        }
                        // ABC.BAC
                        if (el4 + el5 + el6 == el8 + el7 + el9)
                        {
                            listTypeOfSims.Add("ABC.BAC");
                        }
                        // ABC.ACB
                        if (el4 + el5 + el6 == el8 + el9 + el7)
                        {
                            listTypeOfSims.Add("ABC.ACB");
                        }
                        var tempSpecialNum4 = el6 + el7 + el8 + el9;
                        switch (tempSpecialNum4)
                        {
                            // Số đặc biệt
                            case "4078":
                                listTypeOfSims.Add(".4078");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;
                            case "1368":
                                listTypeOfSims.Add(".1368");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;
                            case "1102":
                                listTypeOfSims.Add(".1368");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;

                            // Số tiến đặc biệt
                            case "8910":
                                listTypeOfSims.Add(".8910");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;
                            case "3579":
                                listTypeOfSims.Add(".3579");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;
                            case "2468":
                                listTypeOfSims.Add(".2468");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;
                            case "0246":
                                listTypeOfSims.Add(".0246");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XX_XXXX
                                );
                                break;
                        }

                        var tempSpecialNum2 = el8 + el9;
                        switch (tempSpecialNum2)
                        {
                            case "79":
                                listTypeOfSims.Add(".79");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "39":
                                listTypeOfSims.Add(".39");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "78":
                                listTypeOfSims.Add(".78");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "38":
                                listTypeOfSims.Add(".38");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "66":
                                listTypeOfSims.Add(".66");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "68":
                                listTypeOfSims.Add(".68");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "88":
                                listTypeOfSims.Add(".88");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "89":
                                listTypeOfSims.Add(".89");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                            case "99":
                                listTypeOfSims.Add(".99");
                                phoneNumNew = FormatPhoneNumber(
                                    phoneNumber,
                                    Enums.FormatPhoneNumber.F0XXX_XXXX_XX
                                );
                                break;
                        }
                        //ABC.CBA
                        if (el4 == el9 && el5 == el8 && el6 == el7)
                        {
                            listTypeOfSims.Add("ABC.CBA");
                        }
                        //AAb.xxx
                        if (el4 == el5)
                        {
                            listTypeOfSims.Add("AAb.xxx");
                        }
                        //ABC.Abc+1
                        if (
                            (Int32.Parse(el4) + 1) == Int32.Parse(el5)
                            && (Int32.Parse(el5) + 1) == Int32.Parse(el6)
                            && (
                                (Int32.Parse(el4) + 1) == Int32.Parse(el7)
                                || (Int32.Parse(el5) + 1) == Int32.Parse(el8)
                                || (Int32.Parse(el6) + 1) == Int32.Parse(el9)
                            )
                        )
                        {
                            listTypeOfSims.Add("ABC.Abc+1");
                        }
                        //ABC.xxx
                        if (
                            (Int32.Parse(el3) + 1) == Int32.Parse(el4)
                            && (Int32.Parse(el4) + 1) == Int32.Parse(el5)
                        )
                        {
                            listTypeOfSims.Add("ABC.xxx");
                        }
                        if (
                            (Int32.Parse(el4) + 1) == Int32.Parse(el5)
                            && (Int32.Parse(el5) + 1) == Int32.Parse(el6)
                        )
                        {
                            listTypeOfSims.Add("ABC.xxx");
                        }
                        if (
                            (Int32.Parse(el5) + 1) == Int32.Parse(el6)
                            && (Int32.Parse(el6) + 1) == Int32.Parse(el7)
                        )
                        {
                            listTypeOfSims.Add("ABC.xxx");
                        }
                        if (
                            (Int32.Parse(el6) + 1) == Int32.Parse(el7)
                            && (Int32.Parse(el7) + 1) == Int32.Parse(el8)
                        )
                        {
                            listTypeOfSims.Add("ABC.xxx");
                        }
                    }
                }
            }
            return listTypeOfSims;
        }

        private static string FormatPhoneNumber(
            string phoneNumber,
            FormatPhoneNumber format = Enums.FormatPhoneNumber.F0XXX_XXX_XXX
        )
        {
            var numElement = phoneNumber.ToCharArray();
            string n1 = numElement[0].ToString();
            string n2 = numElement[1].ToString();
            string n3 = numElement[2].ToString();
            string n4 = numElement[3].ToString();
            string n5 = numElement[4].ToString();
            string n6 = numElement[5].ToString();
            string n7 = numElement[6].ToString();
            string n8 = numElement[7].ToString();
            string n9 = numElement[8].ToString();
            string numberFormatted = phoneNumber;
            switch (format)
            {
                case Enums.FormatPhoneNumber.F0XXX_XXX_XXX:
                    numberFormatted = "0" + n1 + n2 + n3 + "." + n4 + n5 + n6 + "." + n7 + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XXX_XX_XXXX:
                    numberFormatted = "0" + n1 + n2 + n3 + "." + n4 + n5 + "." + n6 + n7 + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XXX_X_XXXXX:
                    numberFormatted = "0" + n1 + n2 + n3 + "." + n4 + "." + n5 + n6 + n7 + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XXX_XX_XX_XX:
                    numberFormatted =
                        "0" + n1 + n2 + n3 + "." + n4 + n5 + "." + n6 + n7 + "." + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0X_XXXX_XXXX:
                    numberFormatted = "0" + n1 + "." + n2 + n3 + n4 + n5 + "." + n6 + n7 + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XXX_XXXX_XX:
                    numberFormatted = "0" + n1 + n2 + n3 + "." + n4 + n5 + n6 + n7 + "." + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XX_XXXX_XXX:
                    numberFormatted = "0" + n1 + n2 + "." + n3 + n4 + n5 + n6 + "." + n7 + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XXX_XXXXXX:
                    numberFormatted = "0" + n1 + n2 + n3 + "." + n4 + n5 + n6 + n7 + n8 + n9;
                    break;
                case Enums.FormatPhoneNumber.F0XXXX_XXX_XX:
                    numberFormatted = "0" + n1 + n2 + n3 + n4 + "." + n5 + n6 + n7 + "." + n8 + n9;
                    break;
            }
            return numberFormatted;
        }

        public static List<ReadSimCSVModel> ReadFileCSV(string filePath)
        {
            //
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // Read CSV file
            var employees = csv.GetRecords<ReadSimCSVModel>();

            return employees.ToList();
        }

        public static List<List<object>> ReadFileExcel(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var excelData = new List<List<object>>();
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            var rowData = new List<object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetValue(i));
                            }
                            excelData.Add(rowData);
                        }
                    } while (reader.NextResult());
                }
            }

            return excelData;
        }

        public static bool IsNumber(this object value)
        {
            return value is sbyte
                || value is byte
                || value is short
                || value is ushort
                || value is int
                || value is uint
                || value is long
                || value is ulong
                || value is float
                || value is double
                || value is decimal;
        }
    }
}
