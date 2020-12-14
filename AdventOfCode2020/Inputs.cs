using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    /// <summary>
    /// Static class containing all the inputs for their respective days.
    /// </summary>
    public static class Inputs
    {
        public static IEnumerable<int> Day1() =>  new int[] {
                1650, 1174, 1156, 1874, 1958, 1918, 1980, 1588, 1863, 1656,
                1843, 1738, 2001, 1883, 1941, 1602, 1881, 1927, 1284, 1474,
                1942, 1992, 1925, 1990, 1831, 1907, 1914, 1815, 1921, 1589,
                1224, 1148, 1223, 935, 1726, 1828, 1838, 1611, 1960, 1668,
                1744, 1566, 1902, 1203, 1975, 1225, 2000, 1678, 1950, 572,
                1812, 1568, 1484, 1767, 1509, 1658, 1127, 1870, 1098, 1294,
                1310, 1483, 1865, 1967, 1856, 1963, 1929, 1119, 132, 1969,
                1094, 1523, 1701, 1896, 1631, 1956, 1910, 1672, 1232, 1285,
                1761, 1649, 1931, 1959, 1191, 1846, 1908, 1976, 1500, 1940,
                1924, 1521, 1989, 1635, 1102, 1114, 1948, 2007, 1964, 1926,
                1590, 1900, 1690, 1880, 1596, 1395, 1373, 1937, 1833, 1845,
                1949, 1128, 1218, 1928, 1912, 1893, 1869, 960, 1813, 1645,
                1490, 1318, 1934, 1259, 2005, 1522, 1270, 1089, 1674, 1997,
                1112, 1954, 1769, 1829, 1814, 1922, 1904, 1894, 1595, 1103,
                237, 1943, 1364, 1906, 1971, 1998, 1461, 1606, 1911, 1545,
                1952, 1917, 1582, 1994, 1946, 1935, 1844, 1938, 1633, 2004,
                1132, 1530, 1915, 1982, 1871, 1852, 1613, 1476, 1216, 1834,
                1939, 409, 1895, 1120, 1194, 1135, 1899, 1901, 1439, 485, 1855,
                1136, 200, 1887, 250, 1930, 1506, 1945, 1988, 1170, 1575, 1872,
                1261, 1137, 1978, 1537, 1897, 1837, 1753, 1913
            };

        public static IEnumerable<string> Day2() => new string[] {
                "8 - 11 l: qllllqllklhlvtl",
                 "1 - 3 m: wmmmmmttm",
                 "2 - 4 p: pgppp",
                 "11 - 12 n: nnndnnnnnnnn",
                 "17 - 19 q: qprqdcgrqrqmmhtqqvr",
                 "16 - 17 k: nphkpzqswcltkkbkk",
                 "6 - 9 c: rvcvlcjcbhxs",
                 "18 - 20 v: hbjhmrtwzfqfvhzjjvcv",
                 "5 - 9 z: jzzhzttttnz",
                 "7 - 13 d: bdqdtddddnwdd",
                 "9 - 11 d: ddddddddxdldddd",
                 "6 - 10 f: fblhfdztgf",
                 "2 - 11 b: vszxfnwghcb",
                 "15 - 18 n: nbnmwxnnlkmlknnnhn",
                 "2 - 9 z: lhwqvczrrqqhqlfvkbcm",
                 "15 - 16 d: dndddddddjdddddbdld",
                 "7 - 8 k: kkkmkkkf",
                 "1 - 8 p: rdcmrkbwqjpph",
                 "2 - 6 s: cswdpsjgsfvzkvqqmrqf",
                 "9 - 11 m: mmmmmmmzbmmmv",
                 "8 - 9 j: jjjjjjjjfj",
                 "7 - 8 d: dddsjnds",
                 "1 - 4 f: qffb",
                 "3 - 8 f: cphmtfff",
                 "1 - 13 s: rjsscssstsvssss",
                 "9 - 14 s: gtsnlbqnckhxmssbbs",
                 "12 - 14 j: jfjnjbjrjpdndj",
                 "15 - 16 t: tttttttttttttttwt",
                 "7 - 8 r: rgrdrrrrrrrrjhrrrrrr",
                 "5 - 8 t: lpcqfgzttlt",
                 "1 - 12 r: wrrrrrrjrrrrrrrr",
                 "14 - 19 d: ddvcdddddddhddprldl",
                 "4 - 8 d: pkddlzxsl",
                 "7 - 11 x: xhxqxcfkxwxxnm",
                 "3 - 7 q: qqqqqqjqqqd",
                 "3 - 13 s: rtzsktsdfhtbs",
                 "8 - 15 n: nnnnnnnnknnnnnsnnn",
                 "10 - 13 r: rrrrrrrrrrrrnr",
                 "1 - 9 r: ldfdgzprnptrd",
                 "2 - 3 k: rqkthj",
                 "4 - 7 p: prrpswdpnmpxmjzsp",
                 "12 - 13 p: pmwbptnpppjprfpkppgj",
                 "4 - 6 w: cfwdlw",
                 "2 - 9 r: pnnvrfjhz",
                 "14 - 16 b: bbbbbbbbbbbbbtbbb",
                 "2 - 7 l: xlmzgklxljcl",
                 "1 - 6 c: cccccccc",
                 "11 - 12 w: dmpzfzpwwnwwpggw",
                 "2 - 3 c: xrccccmcc",
                 "12 - 13 k: kkkkkkkvkkkvkknkkk",
                 "10 - 12 h: hhnhcvhhhqhh",
                 "17 - 18 d: dddjddbdzdddvddddw",
                 "1 - 5 p: pppphp",
                 "11 - 13 v: fvvvvjlvbvrvdhbvv",
                 "10 - 14 b: bzxxqcgqnbkmhm",
                 "1 - 14 g: xggghgngqnggggggggg",
                 "9 - 10 s: xslsmpfnxvvssqmgf",
                 "16 - 17 s: nfqggjzbfsssllwns",
                 "9 - 10 w: wwwwwwwwfw",
                 "13 - 15 z: zzzjzzzjzzzzzzgz",
                 "7 - 10 n: jfnwgwnnnn",
                 "4 - 5 b: btbqb",
                 "1 - 5 w: vwflw",
                 "15 - 16 v: vvxvdvvvvzvxmhxvv",
                 "3 - 4 b: cgbbqk",
                 "1 - 3 f: bffffdfclfffgfkf",
                 "6 - 11 m: xckgmdcqmwk",
                 "6 - 9 c: vcptncxbcg",
                 "5 - 6 m: mmmmdm",
                 "2 - 3 d: dmdd",
                 "5 - 7 v: vvhrxkd",
                 "7 - 10 b: bbbbbbqbbbbb",
                 "8 - 9 m: mhvmmwlgm",
                 "3 - 4 x: xvtxkz",
                 "3 - 9 w: wwlwwwwwkqww",
                 "4 - 18 g: mxslljzcgpwsrggqqc",
                 "2 - 3 x: xcff",
                 "16 - 17 j: jjjjjjjjjjfqjfjwhjjj",
                 "9 - 13 p: ppppppppgppppp",
                 "16 - 17 f: fffffffffffffffffff",
                 "3 - 5 c: cncpcck",
                 "9 - 11 c: kzcwczccccmcfsrcc",
                 "3 - 7 s: ssdsssvnsssssjs",
                 "1 - 6 v: vvvvqv",
                 "5 - 7 b: fzbbxbbbgbb",
                 "3 - 9 t: gtttttttftt",
                 "5 - 19 p: ngpnpklwsclptfjvtgm",
                 "3 - 4 d: dddtdddddd",
                 "4 - 5 m: mjmmwl",
                 "11 - 13 l: lllblllllvllrl",
                 "2 - 6 h: cphqvz",
                 "17 - 19 w: gwwrvfglsljwfgxwbbw",
                 "15 - 17 x: gfcxzcwgjmkwfqxrxzrd",
                 "13 - 14 w: lrmhhxwfkwnkwnbsq",
                 "7 - 8 f: ffffffgcff",
                 "11 - 19 v: vvvvvvvvvvzvvvvvvvlv",
                 "7 - 8 k: kxkkkkpk",
                 "7 - 14 v: vfvvvskttcvvvvvfvv",
                 "11 - 12 m: mmmdhmmgmkgmjmr",
                 "1 - 7 p: hpppppppppbnc",
                 "3 - 8 n: rttbbpjnmzn",
                 "8 - 9 n: nrfnnvxrp",
                 "3 - 4 x: tnxnngq",
                 "9 - 12 s: mbhsxshssrtwvm",
                 "11 - 15 n: nwmnlhgjnnptkmn",
                 "1 - 4 x: xmxl",
                 "1 - 6 f: bffffffffff",
                 "2 - 4 r: zrrr",
                 "2 - 3 t: ttmwvt",
                 "3 - 5 n: ngnnr",
                 "13 - 17 p: jtpppfgklkpshpndpp",
                 "1 - 7 r: rrrrrrrrrrrr",
                 "7 - 10 h: hmhhhhhhhzhhhhhhh",
                 "9 - 15 l: glxqscckgxtkzfllk",
                 "2 - 3 s: gfsh",
                 "5 - 6 b: dpphbj",
                 "6 - 13 h: hhhhhhhhhhhbshgh",
                 "5 - 13 d: dddpbddddddddddd",
                 "10 - 11 p: pppppppppdppppp",
                 "5 - 7 j: jjjjjcx",
                 "8 - 9 r: rrrrmrrrm",
                 "1 - 3 f: ffff",
                 "8 - 15 b: bbbbbbbgbbbbbbrb",
                 "3 - 6 h: hhrhhhhhhh",
                 "9 - 10 v: tkwvvvjvvvblvxvxhxvv",
                 "5 - 9 t: ttttttttmtf",
                 "1 - 4 m: fmmmmm",
                 "5 - 9 n: nfnlnkblnnfnxtzn",
                 "3 - 11 v: dnsvvvbvnvvxvj",
                 "8 - 13 h: nfgmbfjhdhlhb",
                 "2 - 14 q: cxtgcrpsxnjshlqbh",
                 "5 - 13 b: bbbbjbbbbbbbbbbbbbb",
                 "4 - 5 l: wldljllcl",
                 "19 - 20 b: jbvbbbbbqqbbbbbbbbbs",
                 "5 - 14 b: bbbbbbbbbbbbbbbbb",
                 "2 - 5 q: qmqjqhfk",
                 "12 - 13 s: sssfsnsssssssxsms",
                 "3 - 17 z: zzzzzzzzzzzzzzzznzz",
                 "13 - 14 t: ttztttstttbttb",
                 "2 - 6 q: vqhhrqlgvckvsrpwmqwz",
                 "15 - 16 d: dddddddddddddddhd",
                 "5 - 6 w: wwwwdwww",
                 "1 - 2 f: jffkf",
                 "6 - 10 j: jjjjjrjwjbjxgpjjjm",
                 "4 - 5 c: cvgccmcqzrcd",
                 "3 - 7 h: mghkhfgzmkz",
                 "10 - 17 f: ffffsfffffffpffwkff",
                 "4 - 9 g: ggbgcgjgggggg",
                 "8 - 11 d: mdnddhpddddm",
                 "6 - 7 c: ctcldgc",
                 "13 - 14 m: mmmmmmmmmmmmlmm",
                 "18 - 19 t: ttttttttptttttnttgt",
                 "7 - 8 g: qngggtghnxggs",
                 "3 - 12 c: scccrbjtdccq",
                 "2 - 3 q: qgqjq",
                 "5 - 6 x: xxxxzxxxxx",
                 "6 - 10 v: nwjsxvzhvgmsglftbpvc",
                 "2 - 5 m: xjtbsffdwmxmhxrmpm",
                 "4 - 7 c: mfgcvqccg",
                 "1 - 7 c: cctcccc",
                 "3 - 4 m: cnnw",
                 "10 - 13 s: sstssssszsssss",
                 "9 - 10 h: hchhhhjhdh",
                 "2 - 4 j: xjjgsz",
                 "4 - 11 b: rbblbbpmbmbdbjgcbhk",
                 "10 - 11 r: rrrrrrrrrjrrr",
                 "3 - 6 g: hvgfzgjrkdf",
                 "1 - 10 b: tbbbbbbpbbbbbb",
                 "12 - 13 n: nhnnnnnnnnjnznnrnrxl",
                 "7 - 13 w: wwmwfncfwdxww",
                 "3 - 4 c: wccq",
                 "7 - 16 x: xxxxxxtxxxxxxxxxx",
                 "3 - 7 k: zmhkssxs",
                 "1 - 8 n: gnnnnnnnnn",
                 "13 - 14 r: rrrrrrrrrrrrmr",
                 "2 - 3 r: rrlr",
                 "3 - 4 c: sccccwvpjpplgctg",
                 "1 - 2 b: svbs",
                 "1 - 2 f: fbfffrff",
                 "6 - 14 l: lllllvlllllxtllqllll",
                 "13 - 14 f: ffffffffkfffjf",
                 "1 - 6 z: zzzrzfzzzzm",
                 "4 - 8 k: kzzktkgrzjdkq",
                 "6 - 8 j: jjjfsgjjbt",
                 "3 - 7 q: qtqqqqq",
                 "17 - 18 x: djxqkrlcwxxxlvhjxh",
                 "6 - 8 c: tqpcgcjc",
                 "2 - 13 f: khqhkkszblvffhfwcg",
                 "7 - 18 p: kjxrtcpptzpxddbkts",
                 "5 - 12 l: llldllllllntm",
                 "2 - 7 q: bvvrnhqhpqw",
                 "2 - 6 s: scssswssss",
                 "1 - 2 n: njdnnnn",
                 "4 - 8 h: hhhzhhhhhhhhhhhhhhh",
                 "9 - 10 j: jjjjjjjjkjjxqjjw",
                 "4 - 9 t: tzdqtlttttktttttcttt",
                 "4 - 5 w: wdwht",
                 "8 - 9 x: xfxxxxfrsxp",
                 "3 - 4 m: mmmmgwwbmztpmbmmmtls",
                 "8 - 17 f: mgzhfgfffswbgnvbc",
                 "5 - 6 t: tttttg",
                 "4 - 18 x: xxxwxxxxxxxbxxxnxxx",
                 "2 - 4 l: cqglmhmtjls",
                 "2 - 4 z: zfgzr",
                 "11 - 18 k: nrdngbjkpckjxwdbrh",
                 "8 - 9 f: fffffffpf",
                 "4 - 7 g: ggtgghgsnggr",
                 "5 - 6 w: wswwlw",
                 "3 - 5 b: dfbbjbccx",
                 "2 - 3 t: tdwfzg",
                 "4 - 5 r: rhrbw",
                 "4 - 5 j: jjjjtjjn",
                 "3 - 4 k: hkzkk",
                 "1 - 2 c: cdzccc",
                 "3 - 5 r: vhlrrvhr",
                 "4 - 9 l: qbjdqldwzdl",
                 "6 - 11 f: flvpvfcfrgg",
                 "17 - 18 g: xgggggghgggglggggz",
                 "5 - 6 v: bhvgvl",
                 "7 - 15 n: nnnnnnnnnnnnnngnnnnn",
                 "6 - 15 d: dtddsddfddmcpdf",
                 "10 - 12 b: bbbbbbbbvlbbbbbbb",
                 "2 - 12 d: szdghlzwxpnd",
                 "3 - 4 z: zzzw",
                 "6 - 15 t: mrnjvfhtlqwlfzt",
                 "8 - 10 x: lcxcbrxxjw",
                 "6 - 13 r: rgszrlzmmlpdngchhxz",
                 "1 - 14 g: fgggggggggggggggggg",
                 "3 - 5 n: znnnjpksqtzt",
                 "17 - 18 l: bcfmqlsltppxwsxslb",
                 "5 - 8 t: tttnctttt",
                 "4 - 5 m: mmmmnmml",
                 "15 - 20 k: kmkpvxkgnckknzkpkqkt",
                 "12 - 15 x: xxxxvxlxxkdxxxx",
                 "1 - 5 v: vjdndsvsjvqzvnv",
                 "1 - 4 k: kkkkkkk",
                 "5 - 8 c: cxccccccc",
                 "2 - 4 v: vdvd",
                 "12 - 14 w: wwwwwwwwwwqwwbww",
                 "2 - 3 b: kbbtbrllwp",
                 "14 - 15 f: ffffffffffffffm",
                 "9 - 10 v: nlngldlnvsbwcvvt",
                 "4 - 5 c: kccxccc",
                 "5 - 9 m: bmmmmmmmzmf",
                 "8 - 9 f: fzfvffjffffv",
                 "3 - 14 r: rrqrrrrrrrrrrjrh",
                 "13 - 14 p: ppptpppppptpqdpm",
                 "6 - 12 t: tttjtvtgcwvttttqkt",
                 "5 - 10 z: glsrzctzzz",
                 "5 - 8 s: gckwcshsl",
                 "17 - 19 n: nnnnhnnnnnnnntwnnnd",
                 "7 - 9 r: rrrrfdrrxrrrrrrrrrrq",
                 "17 - 20 m: rmxbmmvwphmxmzlmbmxm",
                 "14 - 15 l: kkjwtlsrlhltmdl",
                 "14 - 17 f: ffffffffffffffffff",
                 "3 - 13 l: khxtqtwbvpmgll",
                 "2 - 4 w: wwbmww",
                 "9 - 15 n: nwxcnxnckttrkdqnn",
                 "3 - 4 t: fgnwjbtlntsr",
                 "15 - 16 x: mcxxxxxxrxxxpczx",
                 "6 - 16 w: vtcvkmrwvlmwdvrwmqj",
                 "1 - 3 c: mmcjckwn",
                 "1 - 10 c: ccccccccckccccc",
                 "14 - 16 l: kqjhpjgzvxlnxxll",
                 "4 - 7 r: xrtrrrrrcrrmrrrr",
                 "8 - 13 m: mmmmmmmmmmmmcmm",
                 "7 - 8 r: trkrrrrwf",
                 "3 - 4 n: pnjn",
                 "1 - 5 k: skkknkk",
                 "11 - 16 k: kfkkkjkqpqgkzkkkkwsn",
                 "13 - 17 f: gdllffxlxwncljgwf",
                 "3 - 5 s: gwspdtjtnlbsfffvhlg",
                 "15 - 17 m: krmfcsqbmmmjwgkdmm",
                 "13 - 14 l: knhdrdzcmdhlll",
                 "2 - 3 p: frps",
                 "2 - 9 z: lzwnzmvnqgkpbxv",
                 "5 - 9 n: nnngrnnbj",
                 "3 - 5 c: mncnbk",
                 "2 - 5 n: djgnnnnnzbnnnx",
                 "7 - 8 v: vvgvgvvm",
                 "5 - 15 w: wwwwwwwwwwwwwwwwwww",
                 "6 - 7 d: dddddcz",
                 "7 - 9 g: glrgcggvgckrgggz",
                 "2 - 3 n: dnwbnc",
                 "6 - 8 t: lttztzqt",
                 "1 - 4 m: mmmxm",
                 "4 - 14 l: qqhgtftklcnmllcbgbrx",
                 "2 - 3 d: sdnk",
                 "12 - 15 l: lqllljfglvldcql",
                 "2 - 10 k: kgkkkkkkkkxkkkkkkkkk",
                 "10 - 17 h: ljpwchmhhzmhdhmrchp",
                 "6 - 10 w: lpcfgkslrwwrlkhx",
                 "3 - 7 w: wrpwcpw",
                 "8 - 9 z: kczxltgzh",
                 "6 - 11 n: nnnnnhnsnlnnn",
                 "2 - 9 s: smssssssgss",
                 "2 - 4 x: xxwhxbfjj",
                 "1 - 2 z: fzzzzzzzzzzzzzz",
                 "4 - 5 p: pplcdpp",
                 "3 - 4 c: gncxlzc",
                 "16 - 17 x: fxqltszfgnnkxgrxhcbk",
                 "13 - 17 n: nnnnnnnnnnnnnnnnvn",
                 "1 - 6 x: dxxxxxx",
                 "7 - 8 r: scbnvqrpcbgmpmrrs",
                 "2 - 17 d: ddddddddddddddddhd",
                 "13 - 19 v: fvtphwfnmpfpbpjnnbv",
                 "7 - 18 q: cpwqnhqjqfkqqncbsh",
                 "6 - 10 c: cccdcxccncfxcgc",
                 "2 - 4 g: fggsgbgggggcggt",
                 "13 - 17 r: hspwrxrzbrvlmlwgrkxr",
                 "14 - 15 l: pllgllllllllrmv",
                 "12 - 15 g: hqgcgggsxgjxljgdz",
                 "3 - 4 d: dtxd",
                 "7 - 12 d: kddvbkkdldqbkn",
                 "3 - 13 v: vvvvvvvvvvvvtv",
                 "8 - 13 t: tttttttttfttdt",
                 "18 - 19 q: hprbdznbqlfnwzwpqckb",
                 "5 - 12 c: wwlqcgzqzvtczvcldg",
                 "3 - 5 z: xzzzv",
                 "2 - 11 c: xbblzgtwcjcfqqb",
                 "8 - 9 n: nnnvbnmvl",
                 "8 - 9 z: zzzszzzzt",
                 "2 - 3 l: chsrlrl",
                 "2 - 4 f: nffm",
                 "6 - 7 h: hhhhhhhh",
                 "10 - 16 x: xxxxxxxxxxxxxxxwxxxx",
                 "2 - 19 v: ztpvktjgjlmqfrrxfpv",
                 "2 - 5 g: gncgg",
                 "1 - 3 t: hjtttttvgtttttttttt",
                 "3 - 4 s: nbvs",
                 "5 - 10 n: nnnqnnnnbvnnn",
                 "7 - 15 q: qqqqpqqqqqqqqqzqqsqq",
                 "3 - 5 b: sjtwbr",
                 "2 - 4 t: sttxln",
                 "1 - 5 d: ddddd",
                 "12 - 13 v: zvdpfbkkvcpvdvb",
                 "3 - 6 j: cnnjhj",
                 "7 - 8 q: qqrqpbfqjvbtqlqjqkqh",
                 "2 - 4 v: wvvq",
                 "2 - 7 m: mpmrmmmmdnmmmmk",
                 "10 - 14 g: ggmcgggpggcngglm",
                 "3 - 5 g: fsbpglh",
                 "4 - 5 r: rdrtq",
                 "3 - 4 t: qttltttl",
                 "16 - 18 s: sssszpssbnsssssfss",
                 "6 - 9 b: lbxbwbbqn",
                 "2 - 3 m: dmwsg",
                 "4 - 12 p: lmppwmsplppx",
                 "3 - 15 c: lvjmlzwctxnckvclsj",
                 "13 - 14 t: tttttttftstttw",
                 "1 - 5 m: jmmmm",
                 "2 - 3 r: rsfr",
                 "1 - 4 d: xdns",
                 "2 - 3 k: qklrwnskqnx",
                 "1 - 2 r: rrrr",
                 "5 - 8 l: vlsbftlltc",
                 "3 - 12 n: nhjlchbwphmn",
                 "6 - 7 h: thhghhv",
                 "1 - 11 v: vvvvvvsvvvk",
                 "9 - 11 c: ckdqzdkbjczkkcpdj",
                 "7 - 12 b: bbbbbjbbbbbfzbbb",
                 "3 - 6 v: vvwxkv",
                 "6 - 8 t: twttttttt",
                 "12 - 17 g: gfggggggggggggggg",
                 "2 - 3 g: gqgggggggggggggg",
                 "8 - 9 h: fmjhhbjhvv",
                 "4 - 7 q: qqqqqqjsq",
                 "4 - 5 p: hpkjp",
                 "2 - 10 h: bhsgwpwnhh",
                 "15 - 18 p: nwpqxrcxgjxbbxczxb",
                 "2 - 3 k: mtkszk",
                 "9 - 11 c: zccccpccrrc",
                 "5 - 6 c: qnzjgh",
                 "7 - 11 t: ttttttmtttct",
                 "1 - 5 p: pppppprplmpq",
                 "3 - 4 x: sxlc",
                 "12 - 14 q: xsqzxsrrmxvdxq",
                 "1 - 3 k: kklkjkvkkkkkk",
                 "11 - 12 k: ffflkkkkkkqkkks",
                 "2 - 3 z: zlzzz",
                 "10 - 13 k: kkxkkbkkfkckn",
                 "11 - 15 p: wkppvppxqxpnpbpkpppp",
                 "2 - 11 r: krqxlrvhwhlj",
                 "3 - 4 l: llllllrrbll",
                 "12 - 14 n: nthpvpzmwnsnnn",
                 "15 - 18 w: jwsnzwwwwwvwfdwggcw",
                 "15 - 16 k: gtxkxjvtkktkkhkr",
                 "1 - 3 m: kmzmmm",
                 "9 - 10 j: jjjjjjjjvwj",
                 "5 - 8 p: sppkrxzpbppppphpwv",
                 "5 - 7 w: wwwwgwhwwhppmqw",
                 "5 - 6 h: hchhhplrhphqq",
                 "4 - 5 g: bggbg",
                 "3 - 4 h: sbhmtvhhrbd",
                 "1 - 4 l: lqfl",
                 "5 - 7 j: jjjpjljjjj",
                 "3 - 5 q: qqqqdqqqjqqqqqqqqqqq",
                 "1 - 13 k: kkkkkkkkxkkknkk",
                 "12 - 14 z: jzzzzzzzzzzzzvz",
                 "1 - 4 q: bqqq",
                 "8 - 9 w: wkwftfmfx",
                 "7 - 9 s: kssjlslpmqssx",
                 "1 - 2 n: dxzmtsvnfhjnqsfln",
                 "15 - 17 q: bqmqnrcjsmgghgqjr",
                 "8 - 11 z: zzzzzzzdzzfz",
                 "6 - 7 z: znznzzz",
                 "8 - 11 l: jvlntmjwwrrqlkzrhg",
                 "1 - 5 r: rrvrjtrrjzr",
                 "4 - 20 d: fbvprndxpfqplmtkntdd",
                 "7 - 9 l: llllllqlclllll",
                 "3 - 6 n: xrnjzmlbnjwwzdzmdj",
                 "17 - 19 d: ddddddddddddddddxddd",
                 "9 - 10 w: wwwwwckbwhww",
                 "2 - 5 h: gchshhhn",
                 "1 - 4 l: gtlq",
                 "15 - 16 z: zzzzlzzzzzzzzzzhzdzz",
                 "5 - 6 l: lllfllld",
                 "14 - 16 j: jjjjgjjjjjjjjjjjc",
                 "6 - 8 d: dddddrddd",
                 "4 - 5 h: zhshc",
                 "8 - 9 g: gmgxgbfqg",
                 "1 - 8 r: lrrrrrrzrrgrrrrr",
                 "4 - 13 c: mccqccdccccwccccccc",
                 "3 - 4 z: zhzz",
                 "10 - 11 c: crmmvznptct",
                 "2 - 4 l: slblllt",
                 "1 - 6 q: wqqdqqtqqqgdqqq",
                 "2 - 13 l: nlllpwllpjdbxvbp",
                 "6 - 8 l: mxsflqrlhkqhsrmhtwxq",
                 "4 - 9 t: tpwbtdttt",
                 "2 - 7 q: fzqdrbg",
                 "7 - 8 d: ddpldttdddsd",
                 "14 - 17 b: bbbbbbbbbbbbbmbbbb",
                 "4 - 11 x: wfrxkjtpxlcbgc",
                 "6 - 7 n: nnnnnjn",
                 "13 - 16 z: zmqczdggpqzpcrlz",
                 "1 - 8 j: jjjjjjzdmjjtjj",
                 "5 - 6 v: vjsnvmb",
                 "5 - 7 q: nzqqwbqmbjwllj",
                 "2 - 3 j: mtjg",
                 "12 - 15 d: ddxdddddddddddcddd",
                 "4 - 15 g: hssvxrqgngtkcmh",
                 "1 - 4 m: mmmmmmm",
                 "11 - 13 j: jqjjjjjjjjmjj",
                 "3 - 4 z: zznzz",
                 "2 - 6 c: cccmcs",
                 "6 - 10 x: xxxxxgxxlxxpxxxx",
                 "1 - 2 b: bbrbbbbb",
                 "2 - 5 f: xfmkcf",
                 "4 - 5 r: rrrkxr",
                 "3 - 4 z: zslz",
                 "3 - 4 w: kwwh",
                 "15 - 17 x: rfxxcxwxsxsdgnxlxz",
                 "17 - 18 w: rwqlwwgwwwwjwbcjtw",
                 "2 - 4 p: ppjrpp",
                 "16 - 17 b: bbbbbbbbbbbbbbbtb",
                 "5 - 6 b: fbwbqt",
                 "3 - 5 b: bbjvxg",
                 "4 - 5 j: jbhljfjz",
                 "4 - 5 k: fmkkckpj",
                 "18 - 19 w: wpqtwhngztqkvgqrcjf",
                 "5 - 6 t: wttthhtt",
                 "12 - 15 v: kvgvvvcfglsvnsp",
                 "12 - 14 n: nnnnnnnnnnnknnn",
                 "5 - 8 k: xxzhdkmmkkkbwv",
                 "8 - 9 f: fdffdgvwpfffff",
                 "12 - 14 k: kdbsqwkjhvbxrkh",
                 "4 - 7 f: fvhkstfdrwfkvv",
                 "7 - 17 x: cvkbcvbfxxgxhbxxxpbx",
                 "11 - 14 m: jjnmmmsvhzcmcm",
                 "3 - 9 w: qwxsnsxnwzsnmk",
                 "1 - 5 k: tkkkkkkkkkkkk",
                 "5 - 7 h: hhhhhhdh",
                 "3 - 13 c: cclccccccccwccccc",
                 "1 - 4 w: wwwnw",
                 "3 - 7 z: wzzblltdglmfkl",
                 "9 - 12 k: kkkwqjnqskkdhckhvkk",
                 "2 - 5 r: xjtrrsxrrdzlbjvflqxr",
                 "9 - 13 g: gggbzggggjgxkgg",
                 "1 - 8 m: zmmmmmmhmmmmmhmmmmm",
                 "16 - 18 h: hzhhhhhhhhhhhhhhhh",
                 "2 - 7 w: wwwwwwvw",
                 "3 - 4 d: ddhd",
                 "3 - 5 x: jxvzx",
                 "15 - 18 k: kkkkhkckkkkkkkkkkkxk",
                 "11 - 12 m: mmmmmmmmsmwkm",
                 "7 - 8 k: khfkkktj",
                 "2 - 7 f: ffffffff",
                 "2 - 6 q: hqqdhbfvc",
                 "3 - 5 f: rlpffgf",
                 "3 - 4 t: wtltht",
                 "4 - 5 f: fscfx",
                 "2 - 16 t: nmtppmqttqztvdstc",
                 "1 - 15 j: jwgcbkdjlmjjxzwvpvd",
                 "10 - 12 v: vvhvfvvqvvvv",
                 "5 - 6 l: llllbwlll",
                 "1 - 2 z: xmszvzrwpm",
                 "6 - 11 d: dddjndddddq",
                 "4 - 9 r: xwkfwcztcq",
                 "9 - 10 k: ckskkkktkr",
                 "2 - 4 x: txpxfq",
                 "1 - 3 j: sjzj",
                 "7 - 11 x: bbhcswxtnhx",
                 "9 - 10 q: jlqnqmhjqhqq",
                 "4 - 19 d: qddkdmptbvjpbrjdzddl",
                 "7 - 9 d: sqdpdhhdx",
                 "7 - 8 j: gjzmzjgd",
                 "10 - 15 s: gkgsssssssqssssrpc",
                 "5 - 6 v: vvvvhbvh",
                 "1 - 3 c: cccc",
                 "1 - 3 c: ccwcccczgccpccz",
                 "2 - 4 t: tgtmqtl",
                 "11 - 13 w: wwwcwwwwwwlhw",
                 "4 - 5 z: nzgzrz",
                 "4 - 11 s: lhzxmwclxss",
                 "15 - 18 s: hmszwkscbdzsrgssjj",
                 "4 - 5 m: wkvgzjmhxmwlmlmvsjv",
                 "11 - 12 t: lndqtmsfwpjp",
                 "2 - 10 w: wkwwwwwwwww",
                 "10 - 11 t: ttgpwkjltgn",
                 "3 - 9 b: bbvbbbbbtb",
                 "5 - 7 h: rqlbntrhhkjhhhrdhq",
                 "1 - 2 n: rnnrbnn",
                 "8 - 11 n: nnnnnnnpnnnnnn",
                 "4 - 5 s: vhsnsjc",
                 "5 - 7 b: tbbbbbcbb",
                 "1 - 3 q: frbq",
                 "3 - 4 s: xsssmfsgs",
                 "13 - 17 k: kkkkkbfkkkkkvkkkkkkk",
                 "1 - 13 v: zvvvvvvvvvvvvv",
                 "11 - 14 c: cbcmcccccccmccc",
                 "15 - 17 r: skkrrvsrlmrrrrrjdrrr",
                 "1 - 7 m: jmmqmmmmkmmmrkmmr",
                 "9 - 14 f: kstfsxflhffxsffkb",
                 "7 - 9 g: ggggggggvggggg",
                 "13 - 16 t: tttttttgtttttttvtt",
                 "9 - 10 p: ppppppppphp",
                 "3 - 4 w: wwxw",
                 "9 - 13 g: ggggggggrgggvg",
                 "3 - 4 f: ffkffq",
                 "8 - 11 h: hbhhzhhhhhfh",
                 "2 - 4 d: dcnss",
                 "6 - 7 r: rtrrrbr",
                 "5 - 6 r: rrrrxq",
                 "1 - 11 g: fgggggggmkglk",
                 "14 - 15 h: vlqkqhhhfwhxfvs",
                 "3 - 4 w: wlrsgfsw",
                 "1 - 2 v: dxkwzvvxv",
                 "2 - 4 r: rvrcrtrrl",
                 "4 - 6 t: ttktttt",
                 "10 - 15 j: jjjjbtjjtjnjjjk",
                 "5 - 6 s: ssssssss",
                 "5 - 7 s: sfnkzss",
                 "4 - 5 b: shbtb",
                 "2 - 5 j: hjktjm",
                 "1 - 5 h: hhhhdhhhhh",
                 "5 - 17 m: mmmmgmmmmmmmmmmmmrmn",
                 "2 - 6 b: cxgxbbskzgdhr",
                 "10 - 12 k: kkkkkkkkkbkkkkknkmks",
                 "13 - 16 g: ggggggqggggghggggggg",
                 "1 - 2 w: wwwl",
                 "6 - 9 b: bkbbmbbbzb",
                 "6 - 7 m: qrfhmmndrkmc",
                 "5 - 11 p: ggzmjkxpnrpf",
                 "2 - 3 r: rhrr",
                 "6 - 7 f: vppvpwf",
                 "8 - 10 w: wrwwwdvwwjwwww",
                 "6 - 11 c: wxrbztwpcccj",
                 "14 - 17 x: xxxxxxxxxxxxxrxxxxxx",
                 "5 - 8 c: cccccczqccc",
                 "2 - 6 j: jgqjjfjzjjjjjjmjjj",
                 "4 - 7 t: zphkzttgtjdxdtd",
                 "4 - 7 t: wsrtdqgthqjvznbj",
                 "15 - 19 h: hmhhhhzhhhchhmhhhtxh",
                 "1 - 3 z: zzzz",
                 "2 - 3 j: jcvl",
                 "1 - 7 w: wcpwswwgjfb",
                 "3 - 6 c: crsvmcckc",
                 "9 - 10 f: fffffffffjff",
                 "3 - 6 v: hfvpwvgg",
                 "2 - 5 r: dkhrrd",
                 "1 - 5 f: cflmflfdvbz",
                 "3 - 13 k: sfkgcgktfkhrh",
                 "3 - 9 v: mmrprsvzv",
                 "3 - 4 q: qqqbcrkq",
                 "11 - 13 r: rrrwrrrrrrrgrr",
                 "6 - 11 j: tjjjzpsjrjdj",
                 "14 - 18 t: dtbhmtltcwpnzwqtgt",
                 "2 - 5 c: rsccchcc",
                 "11 - 14 m: kmmmmmlvmmtmmm",
                 "7 - 10 x: xhxxxxxbxbhxxxx",
                 "10 - 13 n: nnntnnnnnpnnn",
                 "3 - 10 w: wwwjwgwwwgwmww",
                 "17 - 18 p: phpppnpqppjsrpppzj",
                 "8 - 12 r: rsrbwrrrrrrzr",
                 "9 - 15 q: bqlrdqqxrdqqnxq",
                 "5 - 11 d: sldcndtlpzdb",
                 "1 - 3 w: zwww",
                 "11 - 12 k: tkbkwkkvsblpt",
                 "13 - 14 c: ccccccccccccqc",
                 "1 - 5 c: ccccrc",
                 "4 - 5 f: fffnf",
                 "3 - 4 w: wwwvw",
                 "2 - 4 k: kzkk",
                 "16 - 18 j: jjjjjjjjjjjjjjvqjj",
                 "2 - 8 v: wvqlrnrtgbzrp",
                 "6 - 10 c: cccccdcccccc",
                 "1 - 4 q: bqqqq",
                 "5 - 6 n: nnnnnnn",
                 "2 - 16 f: cjrffhfpfflxljjfp",
                 "3 - 8 g: ggfggggggg",
                 "7 - 8 z: zmzkzzzczwzzzz",
                 "7 - 8 m: mmmmmmmmmm",
                 "7 - 9 f: vzlffftfw",
                 "4 - 10 w: kckwgbmtws",
                 "4 - 5 g: ggghgp",
                 "6 - 17 w: wwwwwwwwwwwwwwwwkw",
                 "3 - 16 f: fffbfffffffffffcff",
                 "9 - 14 l: lllllllwmllmblllhlml",
                 "1 - 4 s: sssdssss",
                 "3 - 4 m: lmnm",
                 "10 - 11 v: vvvvkvsvvvmvhv",
                 "3 - 4 p: pprb",
                 "3 - 4 k: pkqk",
                 "3 - 4 d: ddxd",
                 "7 - 8 b: bbbbbbfb",
                 "5 - 7 w: qbmhsmt",
                 "11 - 12 b: bbbbbbbbbbbgb",
                 "3 - 5 x: xpxbljxt",
                 "2 - 9 z: kzmpqtbvzrqzh",
                 "3 - 16 v: qwvfvltjrpdxmvqv",
                 "2 - 6 n: pdjxzkn",
                 "7 - 8 j: jmzvjkjk",
                 "2 - 5 r: rrfjqqft",
                 "2 - 5 h: pwhfh",
                 "6 - 7 m: mmgvjmm",
                 "11 - 12 r: rrrrrrrrrrxqrr",
                 "1 - 4 n: nnnw",
                 "1 - 5 z: szzzzzdtzz",
                 "7 - 13 j: jjjjjjnjjjjjbj",
                 "10 - 15 w: rwwwwtmwswwwwwwwnmbk",
                 "11 - 13 t: twxhrldqtttmnt",
                 "1 - 2 r: bkbbrwr",
                 "11 - 17 h: hhdhhhhhhshqpbhhn",
                 "4 - 7 c: crgchccbnr",
                 "9 - 11 r: bdhgrzkmrrl",
                 "6 - 8 g: gggggggzz",
                 "3 - 9 g: ggggggggqg",
                 "9 - 11 z: zrfcqtrxxqzcx",
                 "3 - 9 s: zstjqhnvgjjfxknt",
                 "12 - 13 p: pppppwpgcppjppppptp",
                 "6 - 7 k: kkwrkckb",
                 "8 - 9 k: kkkkqzjkn",
                 "8 - 9 l: lrxlkbflrl",
                 "1 - 3 n: nndn",
                 "8 - 9 d: ddhddddddd",
                 "4 - 12 g: zdclfqvdgnzfv",
                 "3 - 5 d: ddddkddddddd",
                 "9 - 11 x: xxxxxxxxqxxx",
                 "4 - 7 t: ttttfftt",
                 "2 - 4 n: wfmnnddqxfm",
                 "16 - 19 r: zhjsgxjkjpqmpvkrjgr",
                 "3 - 7 v: vvfvvvvv",
                 "1 - 2 d: qdwdfj",
                 "6 - 10 h: hhhhhhhhhrhh",
                 "4 - 16 x: xxxpxxxxxxxxxxxxx",
                 "18 - 19 q: qqqqqqqqqqqqqlqqqqf",
                 "6 - 10 g: gkcntgbgbggklsx",
                 "8 - 9 n: nnnnxnnnpnn",
                 "7 - 9 m: msmmmtdvm",
                 "2 - 15 d: twjdrfzntqhnwkd",
                 "1 - 4 z: kzzz",
                 "16 - 18 b: tbbbtbjbtbtflzckhb",
                 "4 - 12 k: kkbhkgkrkgfk",
                 "8 - 10 q: lrqrjqvwmrb",
                 "1 - 3 f: vfhf",
                 "7 - 14 v: vvvvvvrtvvvvvvvv",
                 "4 - 5 n: xnntnwntrfnbqqdk",
                 "3 - 5 r: rhkrzwrhrrr",
                 "2 - 4 b: bspbjb",
                 "5 - 6 s: sfscsc",
                 "6 - 7 x: xxxxxhx",
                 "8 - 10 w: wwwwbzlmqw",
                 "7 - 10 v: fkvdvjbfvd",
                 "2 - 5 q: qtqspqqq",
                 "8 - 9 k: kmhkkhpsk",
                 "5 - 8 h: xhdhjfph",
                 "3 - 6 b: dlbkbb",
                 "1 - 3 w: wwbswwww",
                 "2 - 4 x: mxtx",
                 "2 - 4 l: llrll",
                 "3 - 7 j: kclqzgc",
                 "2 - 3 r: rxrrrgrrrrr",
                 "2 - 4 q: nzwxlmcqqqm",
                 "15 - 16 h: hhhhvmhbhdtbblbh",
                 "13 - 19 l: ltkftclmlllflzltlnb",
                 "4 - 5 p: zmwtpjrltqdmfppz",
                 "6 - 10 t: tjdxqtsbzhvprspljmv",
                 "14 - 17 q: qcqqqqqcqghqqqqqjq",
                 "1 - 5 j: flxrjspwlrdqsnjcs",
                 "14 - 15 m: mmmlmmmmmmmmmwm",
                 "3 - 5 d: dddvkwksdcrktlpd",
                 "8 - 11 l: llcllllxllml",
                 "2 - 4 v: vvvbv",
                 "1 - 3 g: llggz",
                 "3 - 5 q: znqqmt",
                 "15 - 17 f: ffffffffffffffjfff",
                 "17 - 18 q: zwnkmcqdqlqgkwfmqc",
                 "8 - 11 f: fffsrffbfffffvfxf",
                 "1 - 7 b: bbbbbbbb",
                 "3 - 4 l: llzh",
                 "8 - 9 n: nhnnnnqknnbnncncnnl",
                 "9 - 11 v: wvvvvvvbhjc",
                 "15 - 16 q: qcjqvfdcsqwdrqqt",
                 "9 - 10 j: jcckdzkzjjb",
                 "1 - 2 s: hssmsssms",
                 "1 - 3 w: xwww",
                 "2 - 4 l: lllll",
                 "2 - 4 q: qnmq",
                 "16 - 18 t: tttttttgtftttttttt",
                 "5 - 6 t: kttttj",
                 "16 - 17 t: twlqttttttttttmct",
                 "8 - 15 x: xxwpxsqkxgkxgxxbdgx",
                 "17 - 18 h: hhhhhhhhhhblhhhhrq",
                 "12 - 17 m: fmkmmmmqkmmdrbvthm",
                 "2 - 4 b: fbcb",
                 "1 - 14 t: tttttttttttttqtt",
                 "17 - 18 v: vvvvvvvvvvvvvvvvvnv",
                 "7 - 10 x: vxxtxlxxlk",
                 "3 - 5 n: nnmnqnnb",
                 "2 - 8 s: vssjqsssssb",
                 "9 - 11 l: wlllllllllllll",
                 "4 - 14 r: zrlcrxrrrzrrrrr",
                 "3 - 14 n: wrnjpnkndsshqk",
                 "12 - 16 p: ppppzpppppphppppp",
                 "9 - 12 r: rrrrrcbrrfprrrrr",
                 "2 - 3 b: bbrb",
                 "14 - 16 d: tzdjdndddgsddlnddgd",
                 "16 - 18 c: cccccccccccccccwcc",
                 "5 - 6 v: rvvqvt",
                 "11 - 17 s: ssssssssssssssssps",
                 "8 - 9 v: vpvxqvvdvnvhgnvvlvs",
                 "7 - 8 d: ddddqlrt",
                 "7 - 13 d: bfzrkddtdwqld",
                 "4 - 6 c: cccccq",
                 "6 - 8 d: hkdndlqq",
                 "11 - 13 l: ngmllbdklvlmqlz",
                 "8 - 17 m: mmmmfmmmmmmmmmmmlmm",
                 "12 - 15 b: bbsbbcblbsnbzbbfcfzz",
                 "12 - 13 k: gbwkkkkkkkksk",
                 "12 - 14 x: xxxxwxxxxxxdxxxxxxx",
                 "3 - 4 m: mwsmp",
                 "5 - 6 k: kkkkzk",
                 "4 - 5 h: pqslhh",
                 "7 - 13 l: gmpxpvwqrnlfp",
                 "3 - 6 t: sttxtmtn",
                 "11 - 13 r: rrbmbrwrrrrrkhrr",
                 "14 - 16 s: ssssssssssssstsss",
                 "7 - 10 v: vvvvvvhvdvvvkv",
                 "5 - 6 z: sxpzzx",
                 "2 - 4 d: rmxd",
                 "16 - 17 z: zzzzzzzzzzzzzzzzzz",
                 "1 - 3 k: kjkkkkcckkzk",
                 "1 - 11 k: xzkkkkzkppk",
                 "8 - 9 f: bfvfdffzb",
                 "4 - 14 r: rfzcrrlmxqlrrrqr",
                 "7 - 19 t: gtnxjqtnjbkrwpzshqqn",
                 "2 - 5 j: kjjgpddjpjjjffzjjp",
                 "2 - 3 f: cfffh",
                 "1 - 2 x: xxxxx",
                 "3 - 13 j: jjjjjjjjjjjjzfjjj",
                 "7 - 8 m: sgmmpmjmwmmmtfs",
                 "4 - 12 z: zfzqzzszvtml",
                 "6 - 9 b: jsfbpkzwb",
                 "13 - 16 x: zsxxjxxsxxqxpxxx",
                 "8 - 12 b: rlzdlplbgbdgd",
                 "3 - 14 h: hmrhhhhhhhhhrthhhh",
                 "15 - 19 g: mgggggcgggggqgghggg",
                 "2 - 9 p: ppppptppzcf",
                 "6 - 7 b: bbbbbbbbb",
                 "4 - 20 q: skqqvxptdswwnrflkvxq",
                 "4 - 5 t: lqttq",
                 "1 - 10 l: lqkqllvllj",
                 "11 - 15 m: qmmmmmrmqmmmsmf",
                 "6 - 15 s: ssssstssssssssss",
                 "2 - 4 x: xtxxx",
                 "9 - 11 q: qqqqqqqqhqgqq",
                 "1 - 4 n: gpnnfnn",
                 "1 - 3 l: lltl",
                 "11 - 15 k: kkfkkfkmmkrkkkk",
                 "11 - 12 f: fkcvfvtqfcfffffffffj",
                 "1 - 4 c: ccjc",
                 "14 - 15 n: bvbvfvzcbfnzqlsvh",
                 "4 - 5 x: xxlmxx",
                 "3 - 6 n: nnrnnnwlnncnn",
                 "6 - 9 j: jjjjjjjjq",
                 "7 - 10 d: pdplmxdczddbd",
                 "12 - 13 c: ccccbctccccccccc",
                 "12 - 13 j: jfjdjjjjjjjjjj",
                 "6 - 7 h: mrnphwh",
                 "2 - 9 n: njnnnnnnnnnnnn",
                 "3 - 6 g: rgxgggggnjghgggntg",
                 "9 - 12 b: bbbbbbbbbbbcbb",
                 "3 - 5 p: ppppvpp",
                 "16 - 20 t: ctkgpgzrwwngltvxcqct",
                 "4 - 5 s: sssdsh",
                 "12 - 14 v: vvvvvsvvvvvvvsv",
                 "8 - 13 w: zwwwwwwvwwrwgv",
                 "12 - 17 r: wrcrrrrrrrbrwrrrxr",
                 "12 - 13 x: xxxxxxxxxjsvrnxx",
                 "7 - 9 n: nqnnqnvnn",
                 "14 - 19 n: nnnnnnnnnnnnnnnnnnnn",
                 "4 - 5 c: vscjrl",
                 "1 - 3 l: llrl",
                 "11 - 12 w: wwwwwwwwwwzww",
                 "6 - 7 t: wlcktht",
                 "2 - 10 r: rrrrrrrrrwrrrmrr",
                 "2 - 6 x: lhqvpx",
                 "10 - 16 h: kqrhxclktcqhxchg",
                 "6 - 10 m: mmsmkmmjmlmhfmmnmm",
                 "5 - 7 h: hchhhhph",
                 "5 - 7 z: vtzzzwl",
                 "3 - 12 z: zzfzzzzzzzzzz",
                 "7 - 9 z: zzzzzzszzzzzzzzjz",
                 "8 - 9 g: ggggggggg",
                 "13 - 16 f: ptvzfmfkxfdkfhjff",
                 "1 - 10 w: cvhnfgnwpw",
                 "5 - 8 d: fvvmdlfqgjc",
                 "6 - 9 s: rzlrwzngshvt",
                 "2 - 4 v: vgql",
                 "1 - 3 r: rrmrr",
                 "5 - 7 j: jkjgwjj",
                 "4 - 7 b: bbbzdzbbcbbb",
                 "4 - 10 k: kkkkrkckkgkkk",
                 "10 - 12 m: mmmmmmddmjmn",
                 "4 - 10 k: mskmvkcpqkk",
                 "5 - 10 m: wbtdmxnvrmwqbqkwmtq",
                 "7 - 14 z: cfzftzzqnxffzh",
                 "12 - 13 z: zzzzkzzzzdzzz",
                 "4 - 5 l: lllslllvl",
                 "5 - 8 k: kkkkkkkkkk",
                 "10 - 11 l: llllllllllwl",
                 "3 - 5 v: hvzpxfvmvcv",
                 "8 - 10 t: tbtnrtbqzwtkqtf",
                 "6 - 10 j: njjjpjjjjkjsj",
                 "8 - 16 f: cvpxnsxfdnpdfswdhbb",
                 "6 - 12 n: nnndnnnnnnnz",
                 "2 - 3 d: dzdd",
                 "1 - 4 s: jshkscssssssssssssss",
                 "5 - 7 k: kkkqckwkcl",
                 "3 - 4 f: ffdf",
                 "9 - 11 c: cpccccncccqccc",
                 "1 - 8 x: gxxxxgxx",
                 "5 - 15 p: ppvkmmpcvzmmczpz",
                 "12 - 13 p: xppppppppvpnpppp",
                 "7 - 12 n: nwnnnnhcbnjnc",
                 "1 - 4 f: fnzjf",
                 "2 - 5 s: tltqss",
                 "3 - 10 r: rrqkrzvkrtbqcrp",
                 "3 - 14 h: hhhhthhhlrwhhhthp",
                 "2 - 4 b: bkbhbq",
                 "15 - 16 v: vvvvvvvvvvvvvvvsvvv",
                 "1 - 17 h: vtjjhtxrchshpxhsh",
                 "4 - 7 n: jnpnpnn",
                 "3 - 4 h: jvhz",
                 "4 - 5 w: wcpzw",
                 "9 - 10 q: tvxbsfmqqblhq",
                 "3 - 5 s: jssstxfbsssshssgkss",
                 "3 - 9 r: fnrhqkrmtstqjgc",
                 "12 - 15 n: xqwnnnnnnnnmnnn",
                 "13 - 15 q: qqqqqqqqqqqqqqtq",
                 "3 - 4 d: dcdl",
                 "4 - 12 d: vrldnmpndmlgdzrv",
                 "2 - 4 h: mhhh",
                 "3 - 4 f: fcvfc",
                 "1 - 2 w: whwwwz",
                 "7 - 8 m: mpmlmmmmhdbh",
                 "2 - 4 q: qxbqqdsjrdpxf",
                 "6 - 14 r: wbmlhrcgrgrkzqfj",
                 "2 - 7 c: ghcvcdcmcztckct",
                 "2 - 9 n: nnnnnnnnpnnn",
                 "3 - 5 f: zlgffv",
                 "1 - 6 m: ntmmmm",
                 "2 - 4 w: jgqwv",
                 "5 - 12 f: gscfzhmrtxfw",
                 "5 - 7 r: rwzklcrnrrg",
                 "8 - 10 h: hhhzhhhpxhhh",
                 "9 - 11 x: xxxxxxxxfxbx",
                 "7 - 8 q: qdnqnzbq",
                 "2 - 10 s: sssmssslbb",
                 "8 - 9 n: wgfnghnlnkf",
                 "4 - 10 d: dddsdddlds",
                 "1 - 5 k: bfkkkn",
                 "2 - 5 w: wwwwww",
                 "14 - 16 s: bjszbzmcnsvplsrh",
                 "8 - 9 b: bbjbbbbbbvvbbx",
                 "2 - 10 m: dmnrsmtqkf",
                 "7 - 12 f: fbtwftvffsgfwlnw",
                 "9 - 10 h: shhhpshfxhbrdhshh",
                 "4 - 9 t: tgpdtwrmt",
                 "2 - 6 t: vhtwntl",
                 "3 - 5 j: ljjjd",
                 "2 - 3 w: hxwvbxwwbwsvc",
                 "7 - 8 r: rrrzrrnr",
                 "3 - 4 x: jxjh",
                 "7 - 12 w: mjmbtgntdwjwnqztv",
                 "5 - 6 l: vlvllt",
                 "7 - 8 n: nnnnnnpnnnn",
                 "3 - 10 c: wcgcxzcdwmcn",
                 "16 - 18 h: hchhhhhhhhhhhhhcmh",
                 "5 - 11 f: fflffffffflfff",
                 "3 - 13 z: zzzzzzzzzzzzpzz",
                 "6 - 9 k: kkkkkskkkk",
                 "6 - 15 c: ccccccccbccccctccc",
                 "9 - 18 p: klcpzpdwzvpqppspfpp",
                 "10 - 13 b: pbbbbmbbdbwtmd",
                 "10 - 11 v: xvvvvvvvvnnvv",
                 "2 - 4 m: msmmm",
                 "1 - 4 w: rwwlwrwrwwrfngc",
                 "8 - 9 r: rjjlddjrnbr",
                 "13 - 16 d: pzdfzqbwclbjddxtvddf",
                 "14 - 15 q: qqqqqqqqqqqqqbq",
                 "12 - 14 k: kkkjgrkkqkkkkl",
                 "3 - 4 d: gsdnkdfnf",
                 "8 - 17 h: glhfvrshlrqwdrfrh",
                 "2 - 12 l: mflqfvxfgzkmd",
                 "5 - 8 f: ckllfnfbflqgrsd",
                 "1 - 17 m: kckvffhnlmjvdtgpm",
                 "16 - 17 p: pplppppcppppppppppp",
                 "5 - 8 h: hhjbmplh",
                 "7 - 10 s: jsjlwgsssbsvfsvk",
                 "2 - 8 x: xpfxbqxxqxhdrxhqm",
                 "12 - 16 n: nnnnnznnnnnnnnnmnvn",
                 "6 - 12 v: vvvvvvvvvvvgv",
                 "8 - 9 j: pjjjjmjnj",
                 "16 - 17 h: hhhbhjhrhhhhxhhgt",
                 "3 - 11 d: ldpmvddhdrdjdj",
                 "6 - 7 n: nnnnnnnn",
                 "5 - 8 f: tglffvhgnfxzfhf",
                 "13 - 18 r: rrrrrrrrrrbrhrrrrrrr",
                 "19 - 20 n: nnnnnnnnnnnnnnnnnnnj",
                 "7 - 8 w: tpmmxqsw",
                 "5 - 7 c: ccccccr",
                 "9 - 10 l: qltnnlnfllqlw",
                 "6 - 7 g: xggbggz",
                 "7 - 10 s: sssssfcssss",
                 "5 - 7 j: jsjkxwqhjcvjtwjzl",
                 "10 - 14 t: qdtttzttcvtttnn",
                 "12 - 13 b: bbbbbbrbbbbqb",
                 "1 - 15 d: dshhrjkwcjjhlthdts",
                 "7 - 12 p: hrxkphmqpvpptpqbw",
                 "13 - 14 d: ddndddxdtdrkvldd",
                 "3 - 4 h: htht",
                 "7 - 8 c: xtsvzccfckccx",
                 "4 - 5 r: gstrwshptzrdtjj",
                 "7 - 8 b: wbbnbbbm",
                 "15 - 17 c: cgpqxbccqcjpzlcctmx",
                 "2 - 7 k: kvtqqmsx",
                 "8 - 11 s: ssxssssqsssssssss",
                 "3 - 9 d: ddddddddld",
                 "13 - 16 p: pppppppppppppppwpj",
                 "6 - 8 v: sxkghpckvb",
                 "17 - 18 s: ssssssssbsssssssksss",
                 "1 - 2 w: wlwxdsw",
                 "8 - 9 q: qqqqqqqqnq",
                 "9 - 16 f: fjdsfvkfqffffjcfpff",
                 "12 - 13 h: bhhhhhhfwhphhhhhh",
                 "7 - 8 k: kkkkkknkkkkkkk",
                 "4 - 7 w: wwwfpsw",
                 "8 - 11 d: rsndldddddxddmf",
                 "2 - 10 c: cjcdcccccc",
                 "6 - 7 v: zvnrhth",
                 "3 - 8 z: zzxzzzzzdzjzzzzz",
                 "11 - 12 t: tctdttttwtrtttttjth",
                 "8 - 9 c: ccccccccrccc",
                 "17 - 18 p: pppppppppppppppppvp",
                 "3 - 8 l: svlmlkspljr",
                 "1 - 2 n: nwnkq",
                 "1 - 11 j: jjjjjjjjjjjj",
                 "18 - 19 g: ggggggggggggggggggr",
                 "10 - 11 j: jjjjjcdjgjv",
                 "3 - 7 p: ptttppppppj",
                 "2 - 5 d: cdndsd",
                 "6 - 10 s: sssssmssssss",
                 "15 - 16 k: vxwxxhhkkhklqksd",
                 "3 - 4 x: rpxn",
                 "1 - 6 g: vmgckg",
                 "3 - 4 j: jjbs",
                 "5 - 10 d: qrnmbddndvcmdsjjbdhd",
                 "7 - 9 v: vvmgvvvpvm",
                 "1 - 7 z: zzzzzzwzzzz",
                 "4 - 7 n: nnnnnnqn",
                 "8 - 9 k: kwkknknkrkgkbklmpb",
                 "1 - 5 z: zzmzfzz",
                 "6 - 10 m: mmmmmfmmmm",
                 "9 - 11 s: sssssstsssgss",
                 "2 - 6 n: nnfnpgnnnmnnn",
                 "15 - 17 w: wwwwrswthgwhkwwrw",
                 "5 - 9 h: lbhdhplmbnwh",
                 "5 - 6 d: jdddqqt"
            };

        public static char[,] Day3SampleInput()
        {
            var rawInput = new char[] {
                '.', '.', '#', '#', '.', '.', '.', '.', '.', '.', '.',
                '#', '.', '.', '.', '#', '.', '.', '.', '#', '.', '.',
                '.', '#', '.', '.', '.', '.', '#', '.', '.', '#', '.',
                '.', '.', '#', '.', '#', '.', '.', '.', '#', '.', '#',
                '.', '#', '.', '.', '.', '#', '#', '.', '.', '#', '.',
                '.', '.', '#', '.', '#', '#', '.', '.', '.', '.', '.',
                '.', '#', '.', '#', '.', '#', '.', '.', '.', '.', '#',
                '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '#',
                '#', '.', '#', '#', '.', '.', '.', '#', '.', '.', '.',
                '#', '.', '.', '.', '#', '#', '.', '.', '.', '.', '#',
                '.', '#', '.', '.', '#', '.', '.', '.', '#', '.', '#'
            };

            return Day3_Convert1DArrayInto2D(rawInput, 11, 11); ;
        }

        public static char[,] Day3()
        {
            var rawInput = new char[]
                {
                    '.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','#','#','#','#','.','#','#',
                    '.','#','.','#','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','#','.','#','.','.','.','.','.','#','#','#','.','#','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','#','#','#','#','.','.','.','.','#','.','.','#','#','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','#','#','#','.','#','#','.','.','.','.',
                    '#','.','.','.','.','.','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','#','#','.','.','.','.','#','#','.',
                    '#','.','.','.','#','.','#','.','.','.','.','#','.','.','#','.','.','#','#','.','#','#','.','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','.',
                    '.','#','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.','.','#','.','.','.','.','#','.',
                    '#','.','.','#','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','#','.',
                    '.','.','.','#','.','#','.','#','#','.','.','.','#','#','.','#','#','#','.','.','.','.','.','#','.','.','#','.','.','.','#',
                    '.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.',
                    '#','.','.','#','.','#','.','.','#','.','#','.','.','.','.','#','.','.','.','#','.','#','.','.','.','.','.','#','.','.','#',
                    '#','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','#','.','#','.','#','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','#','.','.','#','.','#','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#',
                    '.','.','.','.','#','.','.','#','.','.','#','.','.','.','#','.','#','.','#','#','.','.','.','.','.','.','#','.','.','.','#',
                    '#','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','#','.','.','.',
                    '.','.','#','.','.','.','#','.','#','.','.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','#','#','.','#','#','.',
                    '.','.','.','.','#','#','.','.','.','#','#','.','#','.','.','.','.','#','.','.','.','.','.','#','.','#','#','.','.','.','.',
                    '#','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','#','.','#','.','#',
                    '.','.','.','.','#','.','#','.','#','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','#','.','.','#','.','.','.','.','#','.','.','#',
                    '.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.',
                    '.','.','#','#','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#',
                    '.','.','.','.','.','#','.','.','.','.','#','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','#','.','#','.','.','.','.','#','#','.','#','#','#','.','.','.','.','#','.','.','.','#','.','.','.','.',
                    '.','.','.','#','#','.','#','.','.','.','.','.','.','.','#','.','.','.','.','#','#','#','.','.','#','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','#','.','.','.','#','.','.','.','.','.','.','.','.',
                    '#','.','.','#','#','#','.','.','#','.','.','.','.','.','#','.','#','#','#','#','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.',
                    '#','.','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','#',
                    '#','.','#','#','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.','.','.','.','#','#','.','.','#','.','#','.','#',
                    '.','.','.','.','.','.','#','.','.','.','.','#','#','.','#','.','#','.','.','.','#','.','.','.','#','#','.','.','.','.','#',
                    '#','.','.','#','.','.','.','.','#','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.','.',
                    '.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','#',
                    '#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','#','.','#','.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','#','.','.','#','#','.','.','.','.','.',
                    '.','.','.','.','.','.','#','#','#','.','.','.','.','.','#','.','.','#','.','.','.','#','.','#','#','#','.','.','.','#','#',
                    '.','#','#','.','#','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','#','.','.','.','#','.','.','.',
                    '#','.','#','.','.','#','.','#','.','#','.','.','.','.','#','.','.','.','.','.','#','#','#','.','.','#','.','.','.','#','#',
                    '.','.','.','.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.',
                    '#','.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#','.','.','.','#','#','.','.','.',
                    '.','.','#','.','.','.','#','.','.','.','.','#','.','.','.','.','#','#','#','.','#','.','.','.','.','.','.','#','.','.','.',
                    '.','.','.','.','.','#','.','.','#','.','#','#','#','#','#','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.',
                    '.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','#','#','.','#','.','.','.','.','#','#','.','#','.','#','#',
                    '.','.','.','#','.','#','.','#','.','.','.','.','#','.','.','.','.','#','#','.','.','#','.','.','#','.','#','.','#','#','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','#','.','.','#','.','.','#','#','#','#','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','#','#','#','#','#','.','#','.','#','.','#','.','.','.','#','.','#','#','.','#','.','.',
                    '.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','#','.','#','#','.','#','.','#','#','.','.','.','.',
                    '.','.','.','.','#','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','#','.','#','#','#','.','.','.','.','#','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.',
                    '#','.','.','.','#','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','#','#','#','.','.','.','.','#','.',
                    '#','#','.','.','.','.','#','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','#','.','#','.','#','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','.',
                    '.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','#','.','#','.','#','#','.','.','#','#','#',
                    '.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','#','.','.','#','.',
                    '.','.','#','#','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','#','#','.','.','#','.','#','#','.','.','.','#',
                    '.','.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','#','.','.','#','.','.',
                    '.','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','#','#','.','.','.',
                    '.','.','.','#','#','.','.','.','.','#','.','#','.','#','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#',
                    '.','.','.','.','#','.','#','.','.','.','.','.','.','.','#','.','.','#','#','#','.','.','#','.','.','.','.','#','#','#','#',
                    '#','.','.','.','#','.','.','.','#','#','.','.','#','.','#','#','#','#','.','.','#','.','.','.','#','#','.','.','.','.','#',
                    '.','.','.','.','.','.','.','#','.','.','#','.','#','#','.','.','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.',
                    '#','#','#','.','#','.','.','.','.','.','.','#','.','.','#','#','.','.','#','.','.','.','.','.','.','#','.','#','#','.','.',
                    '#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','#','#','.','.','.','#','.','.','#','#','.','.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.','.',
                    '.','#','.','.','#','#','.','.','.','#','.','.','.','.','#','.','#','.','.','.','#','.','.','.','#','.','.','#','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','.','.','#','#','#','.','.','.','#','.','.','#','#','.','.','#','#','#','.','#',
                    '.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','.','.','#','.','#','.','#','.','.','.','#',
                    '.','#','.','.','.','.','#','#','#','.','#','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#',
                    '.','.','#','.','.','#','.','#','.','.','#','.','#','.','#','#','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.',
                    '#','#','.','.','#','.','#','.','#','.','.','.','.','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.',
                    '#','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.','.','#','#','#','#','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.','#','#','.',
                    '#','.','.','.','#','.','.','#','.','#','.','.','.','.','#','.','.','#','.','#','.','.','.','.','#','#','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '#','.','.','.','.','.','#','#','.','.','#','#','#','.','.','#','.','#','.','.','#','.','#','.','#','#','.','.','#','.','#',
                    '#','.','.','#','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','#','.','.','.','.',
                    '#','#','.','.','#','.','#','.','.','#','.','.','.','#','.','.','.','.','.','.','#','.','#','#','.','.','.','#','#','#','.',
                    '.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','#','.','.',
                    '.','.','#','.','#','.','.','#','#','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','.',
                    '.','#','.','#','.','.','.','#','.','.','#','.','.','.','.','.','#','.','#','.','.','#','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','#','.','#','.','.','#','.','#','.',
                    '.','.','.','.','#','.','#','#','#','.','.','.','#','#','#','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.','#','#','.','.','.','.','#','#','.','.','.','.','.',
                    '.','.','#','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.','.','#',
                    '.','.','.','.','.','#','.','#','#','#','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','.','.','#','#','#','.','.','.','#','.','.','.','.','.',
                    '.','#','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.','#','#','#',
                    '#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#',
                    '#','.','.','#','.','#','.','.','#','.','#','.','#','.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.',
                    '.','#','#','.','#','#','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.',
                    '.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','#','.','#','.','.','.','.','#','.','.','.','#','#','.','.','#','.','.','.','#','.','.','.','#','#','.','.','.','.','.',
                    '.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.',
                    '.','.','.','.','#','.','#','.','.','#','.','#','.','.','#','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.',
                    '.','.','.','.','#','#','.','.','.','.','.','#','.','#','#','.','.','.','.','#','.','#','#','.','.','#','#','.','.','#','#',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','#','#','.','#','#','.','.','#','.','.','.',
                    '.','#','.','.','#','.','.','.','.','.','.','.','.','.','#','.','#','#','.','.','.','.','#','.','.','.','.','#','.','.','#',
                    '.','#','.','.','#','#','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','#','.','#','#',
                    '.','#','#','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.',
                    '.','.','.','#','.','#','#','.','#','#','.','#','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','#','#','.','#',
                    '#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','#','.','.','.','#','#','#','.','.','.','.','#','.','#',
                    '#','.','.','#','#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','.','#',
                    '.','.','.','#','.','#','.','.','.','.','#','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','#',
                    '#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.',
                    '#','#','#','.','.','.','.','#','.','#','.','.','.','#','.','#','.','.','#','#','#','#','.','.','.','.','.','.','.','.','.',
                    '.','#','#','.','#','.','#','.','.','.','#','#','.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','#','.','.','.',
                    '#','.','.','.','.','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.',
                    '.','.','#','#','#','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','.','#','#','.',
                    '#','.','#','.','#','.','#','.','.','#','.','.','.','.','.','#','#','.','.','#','#','.','#','.','.','.','.','#','.','.','.',
                    '.','.','.','#','.','.','.','#','.','.','#','.','.','.','#','.','.','#','#','.','.','#','#','.','.','.','.','.','.','.','.',
                    '.','.','.','#','#','.','.','.','#','#','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','#','#','#','#','.','.','#','.','#','.','#','.','#','#','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','#','.','.','#','#','.','.','#','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','#','.','.','#','.','.','#','.','#','.','.','#','#','#','.',
                    '.','#','.','.','.','.','#','.','.','.','.','#','.','.','#','.','.','#','#','.','.','.','.','.','#','#','.','.','.','#','.',
                    '.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#','#','#','.','#','.','.','.','#','.','#','.','.',
                    '#','.','.','#','.','.','#','.','.','.','.','.','.','#','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '#','#','.','#','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.',
                    '.','.','.','.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','.','#','.','.',
                    '.','.','.','#','.','.','#','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','#','#','.','#','#','.',
                    '.','.','.','.','#','.','.','.','#','.','.','.','#','.','#','#','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.',
                    '.','#','.','.','#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','#','.','#','.','.','#','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','#','.','.','.','#','#','.','#','#','.','.','.','.','.','.','#','.','#','.','#','.','#',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','#','.','#','.',
                    '.','.','.','#','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','#',
                    '.','.','.','.','#','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','#','.',
                    '#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','.','#','.',
                    '.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.','#','.','#','#','#','#','.','#','.','#','.','.','.','.',
                    '#','#','#','#','.','#','.','.','#','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.','#','#','.','.','.','.','.',
                    '#','.','.','.','#','#','.','.','#','.','.','.','#','#','#','#','.','.','#','.','.','.','.','#','.','#','.','.','.','#','.',
                    '.','.','#','.','.','.','.','.','.','.','#','.','#','#','.','.','#','#','.','.','.','#','.','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','.','.',
                    '#','.','#','#','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.',
                    '.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','#','.','.','.','.','.','.','#','.','#','#','#',
                    '.','#','.','.','#','.','.','#','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','#','#','.','.','#','#','#','.',
                    '.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','.','#','#','.','.','.','.',
                    '.','.','.','.','#','#','#','#','#','#','#','#','.','.','.','.','#','.','#','.','#','.','#','#','#','.','#','.','.','.','#',
                    '.','.','.','#','.','#','#','#','.','#','#','#','.','#','#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#',
                    '.','#','.','.','.','#','.','#','#','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.',
                    '.','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','.','#','#','.','#','.','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','#','.','.','#',
                    '#','.','#','#','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','#','.','#','.','.','.','.','#','.','#','#','.','.',
                    '.','.','.','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','#','.','.','#','#','.',
                    '#','.','.','.','.','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','#',
                    '.','.','.','#','.','#','.','#','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.',
                    '#','#','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','#','.','#','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.',
                    '.','.','.','.','#','.','.','.','#','.','.','#','#','#','.','.','.','#','.','#','.','.','.','.','#','.','.','.','.','.','.',
                    '#','.','.','.','.','.','.','.','.','.','.','.','#','#','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.',
                    '.','.','#','.','.','#','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','#','#',
                    '#','.','.','.','.','.','#','.','.','#','#','#','.','.','.','.','.','#','.','.','.','#','#','.','.','#','#','.','.','.','.',
                    '#','#','.','.','#','#','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','#','.','.',
                    '.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.',
                    '#','.','.','#','.','#','#','.','#','#','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','#',
                    '#','.','.','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.',
                    '.','#','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','#','#','.',
                    '#','.','.','#','.','.','#','#','.','.','.','.','.','#','.','.','.','#','.','#','.','#','.','#','.','.','#','#','#','.','.',
                    '.','#','.','#','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','.','#','#','.','#','.','#','.','.','.','.',
                    '.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','#','#','#','.','#','.','.','.','#','.','#','.','#','#','#','.',
                    '.','.','.','.','#','#','.','.','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','#','.','#','#','.','.','#',
                    '.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','#','.','.','.','.','#','.','#','.','#',
                    '.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','.','.','.','.','#','.','#','.','.','#','.','.','.','#','.',
                    '.','#','.','#','.','.','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.',
                    '.','.','.','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','#','#','.','.','#','#','.','.','#','#','#','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','#','#','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.',
                    '.','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.',
                    '#','#','#','#','.','.','.','.','.','.','.','#','.','.','.','#','#','.','#','#','.','.','#','.','#','.','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.','.','.','#','#','#','.','.','#','.','.','.','.','#','.',
                    '.','#','.','.','.','.','.','.','.','#','.','.','.','#','#','.','.','.','#','.','.','#','#','.','#','.','.','.','.','.','.',
                    '#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','#','.','.','.','.','#','.','#','.','#','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#',
                    '#','.','#','.','.','.','#','.','#','.','.','#','#','.','.','#','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.',
                    '.','.','.','#','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.',
                    '#','.','#','.','.','.','#','.','#','#','.','.','.','.','#','#','#','.','.','.','.','.','.','#','#','.','.','.','.','#','.',
                    '#','.','.','#','.','.','.','#','#','#','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','#','.',
                    '#','.','.','.','.','#','.','.','.','.','#','#','#','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','#','.','.',
                    '.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','#','.','#','#','.','.','.','.','.','.','.','.','#','#','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.','#',
                    '#','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','#','.','#','.','.','.','.','.',
                    '.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.','.','#','.','.','.','.','.','.',
                    '.','#','.','.','#','#','.','#','#','.','#','.','.','.','#','#','.','.','.','.','#','.','#','.','.','.','.','#','#','.','.',
                    '.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','#','.','.','.','.','#','.','#','.','.','#','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','.','#','.','.','#','.','.',
                    '.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.',
                    '.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','#','#','#','.','.','#','#','#','.','.','.','#','.','#','.','#','.','.','#','.','.','.','.','#',
                    '#','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','#','.','.','#','#','.','.','.','.','#','#','.','.','.','.',
                    '#','.','#','.','.','.','.','.','.','#','#','#','.','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','#',
                    '#','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','.','#','.','.','.','#','.','.','.','#','.','.','.','.',
                    '.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','#','#','.','#','.','.','#','.','.','.',
                    '.','#','#','#','#','.','.','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','#','.','.','#',
                    '.','.','#','#','#','.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.',
                    '.','.','#','#','.','#','.','#','.','.','#','.','.','.','.','#','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','#','#','#','#','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','#','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.',
                    '.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','.','.','#','#','.','#','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','#','#','.','.','.',
                    '#','#','.','#','#','#','#','.','.','#','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','#','#','#',
                    '.','.','#','.','.','#','.','.','.','#','.','.','.','#','.','.','.','.','.','#','#','.','.','.','.','#','.','.','#','.','#',
                    '#','.','.','#','#','.','.','#','.','.','.','.','.','#','.','.','.','.','#','.','#','.','.','.','.','.','#','#','.','.','#',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','.','#','.','.','#','#','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','#','#','.','.','#','.','.','.','#','.','.','.',
                    '.','#','.','.','.','#','.','#','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','#','#','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','#','#','.','.',
                    '.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.',
                    '#','#','.','.','.','.','.','.','.','#','#','#','.','.','#','#','#','.','.','.','#','#','.','.','.','#','.','.','.','.','.',
                    '#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','.','.','.',
                    '.','.','#','#','.','.','.','.','.','.','.','.','#','.','#','#','#','.','.','.','.','.','#','.','.','.','.','#','#','.','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.',
                    '.','.','#','.','#','#','#','.','.','#','#','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.','#','#','.','#','.',
                    '.','.','.','.','.','.','.','.','#','#','.','.','.','#','.','.','#','.','#','.','.','#','#','.','.','.','.','.','#','.','#',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#',
                    '.','.','#','#','.','#','#','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.',
                    '#','#','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.',
                    '.','.','.','#','.','.','#','#','.','.','#','#','.','.','#','.','#','.','#','#','#','.','.','#','.','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','#','.','.','#','.','.','#','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.',
                    '.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.',
                    '.','#','.','.','#','.','.','.','.','#','#','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.',
                    '.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','#','.','#','.','.','.',
                    '.','.','.','#','.','.','.','.','#','#','#','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.',
                    '#','.','#','.','#','#','.','#','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','#','.',
                    '.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','.','.','.',
                    '.','#','#','.','.','.','#','#','.','.','.','.','.','.','#','#','.','.','.','#','#','#','.','.','.','#','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','.','#','#','.','.','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','.','.','#','#','.',
                    '#','#','#','.','.','.','#','.','.','.','.','.','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','#','.',
                    '#','#','.','.','.','#','.','.','#','.','.','.','.','.','#','.','#','.','.','.','.','#','.','#','.','#','.','.','.','.','.',
                    '#','.','.','#','#','.','.','.','.','.','.','.','#','.','.','.','#','.','#','.','.','.','#','#','.','.','#','.','.','.','.',
                    '#','.','.','.','#','.','#','#','.','.','.','.','.','#','.','#','.','.','#','.','#','#','.','.','.','.','.','.','#','.','#',
                    '.','.','#','.','.','.','.','.','.','#','.','#','.','#','.','#','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','#','.','#','#','.','.','.','.','.','.','#','.','#','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','#','#','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','#','.','#','.','.','#','.','.','.','#','#','.',
                    '.','#','.','.','#','#','.','#','.','.','#','.','.','.','.','#','.','#','.','.','.','.','.','.','#','.','#','#','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','#','.','.','#','.','.','.','.','.','#','.','#','.',
                    '#','.','.','.','#','.','#','.','.','.','.','.','.','#','#','.','.','.','#','.','.','#','.','.','.','#','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','#','.','.','.','#',
                    '#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','#','.','.','.','.','.','#','#','#','#','.','.','.','#','.','.','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.',
                    '.','.','.','.','#','.','#','.','.','.','#','#','.','.','#','#','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.',
                    '#','.','#','.','.','.','.','.','.','#','.','.','.','#','.','#','.','#','#','#','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','#','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','.','#','#','.','.','.','.','#','.','#','.','#',
                    '.','#','.','.','.','.','#','.','.','.','.','.','.','#','.','#','.','.','.','#','#','#','.','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','.','#','.','.','.','#','#','.','.','.','.','#','.','#','.','.','.','.','#','.','.','.','.',
                    '.','.','.','.','.','#','#','.','.','#','#','.','.','.','#','.','.','#','.','#','.','.','.','.','.','#','#','.','.','#','.',
                    '.','#','#','.','.','#','.','#','.','#','.','.','.','.','#','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','.',
                    '.','#','.','.','#','.','.','#','#','.','.','.','.','#','.','#','#','.','.','.','.','.','.','.','#','.','.','.','#','.','.',
                    '.','.','.','.','#','.','#','#','.','.','.','#','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.',
                    '.','#','.','.','#','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','#','#','.','.','.','#','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','.','.','.','.','.','.','.','#','.','#',
                    '.','#','.','#','.','.','.','.','#','.','.','.','.','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','.','.',
                    '.','#','#','.','.','.','#','.','.','.','#','.','#','.','.','.','.','#','.','.','.','.','#','.','#','.','.','.','.','.','#',
                    '#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','#','#','#','#','.','#','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','#','.','.',
                    '#','.','#','.','.','#','#','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','#','.','#','.','.','#',
                    '#','#','.','#','#','.','.','#','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#',
                    '.','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','#','#','.','#','.','#','.','.','#','.','.','.','#','.','.','.','.','.','#','.','#','#',
                    '.','.','#','.','.','.','.','.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.',
                    '.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','#','#','.','.','.','#','.','#','.','#','#','.','.','#','.','.',
                    '.','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','#','#','.','.','#','#','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','#',
                    '#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','#','#','.','.','.','.','#',
                    '.','.','#','.','.','#','.','.','#','.','#','.','#','.','.','.','.','#','#','.','.','.','#','#','.','.','.','.','.','.','#',
                    '#','.','#','.','.','#','.','.','#','#','#','.','#','.','.','#','.','.','.','.','.','#','#','#','#','.','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','#','#','#','.','.','.','.','#','.','.','.',
                    '.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','#','#','#','#','#','#','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','#','.','.','#','.','.','#',
                    '.','#','.','.','#','.','#','.','.','#','.','.','.','.','#','.','#','.','.','#','#','.','.','.','#','.','.','#','.','#','.',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','#','.','#','.','#','#','.','.','.','.','.',
                    '.','.','.','#','.','#','.','#','.','.','.','.','#','#','.','#','#','#','.','.','.','.','#','.','.','.','#','#','#','#','.',
                    '.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','#','#','.','.','.','#','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','#','.','#','.','.','.','.','.','.','#','#','#','.','.','#','#','#','#','.','.','#','.','.','.','.','.','.','#','.',
                    '#','#','#','.','#','#','.','#','.','.','#','.','.','.','.','.','.','#','#','.','#','.','.','#','#','.','.','.','.','.','#',
                    '.','.','.','.','#','#','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','.','#','#','.','.','.','#','.','.','.','#','#','.','.','.','.','#','.','.','.','#','.','.','.',
                    '#','.','.','.','.','.','#','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.','#','.','.','#','.','.','.','.','.',
                    '#','#','#','#','.','.','.','.','.','.','.','.','.','.','#','#','.','#','.','#','.','.','#','.','.','.','.','.','#','#','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','#','.','.','#','#','.','#','.',
                    '.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','#','.','#','.','.','#','.','.','#','.','.',
                    '#','.','.','.','.','#','#','#','.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','#','#','.','#',
                    '#','.','.','#','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.',
                    '.','.','.','#','.','#','.','#','#','#','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.','.','.','#','.','.','.',
                    '#','.','.','.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','.',
                    '#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#',
                    '.','.','#','.','#','.','.','.','.','#','.','#','.','.','#','#','.','#','.','.','.','#','.','.','#','.','.','.','.','#','.',
                    '#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','#','#','.','.','.','.','#','.','.','.','#',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#',
                    '#','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','#','.','.','.','.','#','#','.','.','#',
                    '#','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.',
                    '.','.','.','.','.','.','.','.','#','.','.','.','#','#','#','.','#','#','.','#','.','.','#','#','#','.','#','.','.','.','#',
                    '.','.','.','#','#','.','.','.','#','.','.','#','.','.','#','.','.','.','#','#','.','.','#','#','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','.','.','.','.',
                    '.','.','.','.','.','#','.','.','.','.','#','.','.','#','.','#','.','.','.','#','#','.','#','.','#','.','.','.','.','.','#'
                };

            var twoDInput = Day3_Convert1DArrayInto2D(rawInput, 323, 31);
            for (int counter = 0; counter < rawInput.Length; counter++)
            {
                twoDInput[counter / 31, counter % 31] = rawInput[counter];
            }

            return twoDInput;
        }

        private static char[,] Day3_Convert1DArrayInto2D(char[] input, int rows, int columns)
        {
            var twoDInput = new char[rows, columns];
            for (int counter = 0; counter < input.Length; counter++)
            {
                twoDInput[counter / columns, counter % columns] = input[counter];
            }

            return twoDInput;
        }

        public static string[] Day4SampleInput() => RawConverter(@"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd
byr:1937 iyr:2017 cid:147 hgt:183cm

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr:2024
ecl:brn pid:760753108 byr:1931
hgt:179cm

hcl:#cfa07d eyr:2025 pid:166559648
iyr:2011 ecl:brn hgt:59in", new[] { Environment.NewLine + Environment.NewLine });

        public static string[] Day4() => RawConverter(Day4Raw, new[] { Environment.NewLine + Environment.NewLine });
        private static string Day4Raw => @"pid:827837505 byr:1976
hgt:187cm
iyr:2016
hcl:#fffffd
eyr:2024

hgt:189cm byr:1987 pid:572028668 iyr:2014 hcl:#623a2f
eyr:2028 ecl:amb

pid:#e9bf38 hcl:z iyr:2029 byr:2028 ecl:#18f71a hgt:174in eyr:2036

hcl:#cfa07d byr:1982 pid:573165334 ecl:gry eyr:2022 iyr:2012 hgt:180cm

cid:151 hcl:#c0946f
ecl:brn hgt:66cm iyr:2013 pid:694421369
byr:1980 eyr:2029

ecl:brn
pid:9337568136 eyr:2026
hcl:#6b5442
hgt:69cm iyr:2019 byr:2025

cid:66 hcl:#efcc98 pid:791118269 iyr:2013
eyr:2020 ecl:grn hgt:183cm byr:1993

eyr:2022
hgt:160cm iyr:2016 byr:1969 pid:767606888 ecl:gry hcl:#6b5442

hgt:157cm eyr:2026 ecl:oth hcl:#efcc98 byr:1938 iyr:2014

byr:1931 iyr:2015
ecl:gry
hgt:76in
cid:227 hcl:#09592c eyr:2024 pid:276365391

ecl:gry hgt:170cm iyr:2014 cid:285 pid:870052514
hcl:#866857 byr:1925 eyr:2025

eyr:2021
byr:1960 pid:569950896
iyr:2010 hgt:179cm hcl:#888785 cid:167

hgt:154in cid:194
pid:8142023665 byr:2010 hcl:7d22ff ecl:utc iyr:2026 eyr:1976

ecl:blu eyr:2030 hgt:192cm
pid:363860866 iyr:2019 hcl:#ceb3a1 byr:1963

byr:1947 hgt:167cm hcl:#7d3b0c ecl:amb
cid:70 eyr:2022 iyr:2019 pid:756932371

hgt:185cm pid:871945454
iyr:2020
hcl:#866857 ecl:amb
byr:1989 cid:184 eyr:2030

byr:1935 pid:322117407
hgt:153cm iyr:2011
cid:244 eyr:2022 hcl:#efcc98 ecl:hzl

ecl:blu hcl:#5e6c12
eyr:2029 iyr:2011 hgt:191cm byr:1992

hcl:#7d3b0c eyr:2029
hgt:163cm
pid:625292172 byr:1932 ecl:brn
iyr:2020

hgt:158cm
eyr:2030 iyr:2016 byr:1969
cid:173 pid:092921211 hcl:#602927 ecl:grn

hcl:#733820
iyr:2016 eyr:2029
ecl:hzl hgt:180cm pid:292904469 byr:1984

ecl:amb pid:901224456 hgt:190cm
iyr:2013
hcl:#733820
byr:1922

pid:262285164 iyr:2010
byr:2018 eyr:2026 hcl:#602927 hgt:179cm ecl:gmt cid:349

byr:1956 eyr:2027 pid:351551997 hgt:71in cid:277 hcl:#cfa07d iyr:2010 ecl:grn

eyr:2027 hcl:#602927 hgt:157cm ecl:gry
cid:128 byr:1953
pid:231551549 iyr:2012

iyr:2011 pid:771266976
cid:264 byr:1955 hcl:#b6652a
hgt:189cm ecl:blu
eyr:2030

eyr:2026 pid:698455242
byr:1949 ecl:gry hgt:190cm
iyr:2013 hcl:#efcc98 cid:139

ecl:blu hgt:181cm byr:1977 iyr:2011 eyr:2022
pid:454163967 hcl:#b6652a

pid:534506872 hgt:155cm iyr:2012
byr:1968
cid:333 eyr:2024 hcl:#623a2f
ecl:amb

hgt:162cm
iyr:2020
hcl:#733820 eyr:2027 byr:1995 ecl:gry pid:084994685

iyr:2016 byr:1990
ecl:amb pid:185689022 eyr:2025
hgt:184cm hcl:#866857

byr:2016 hcl:z iyr:2022 hgt:166in
eyr:2040

byr:1943 hgt:152cm hcl:#cfa07d ecl:hzl iyr:2016 cid:300 pid:376088014

iyr:2020 eyr:2026 hcl:#602927 ecl:gry byr:1962 pid:453907789 hgt:172cm

eyr:2023 hgt:185cm
hcl:#623a2f pid:963767258 byr:1977
iyr:2019 ecl:oth

hgt:159cm byr:1965 cid:349 ecl:blu pid:962908167
iyr:2013 eyr:2024
hcl:#fffffd

eyr:2026
pid:912822238 hgt:66in byr:1985 iyr:2018 hcl:#c0946f ecl:hzl

hgt:167cm hcl:#ceb3a1
byr:1990 eyr:2027 ecl:grn
iyr:2011 pid:642877667

hcl:#7d3b0c byr:1921 pid:976412756 hgt:192cm
iyr:2013 ecl:gry

iyr:2030 pid:283599139
eyr:2039 cid:203
hcl:f943cb
hgt:111

hgt:190cm
iyr:2027 ecl:blu hcl:z
byr:2004 eyr:2039
pid:734570034

hcl:#6b5442 hgt:191cm
ecl:oth byr:1989 pid:669414669 cid:196 iyr:2016 eyr:2023

ecl:brn eyr:2028 byr:1965 pid:630674502 hcl:#602927 iyr:2020 hgt:61in

iyr:2016 eyr:2022 cid:225
hcl:#733820 ecl:hzl hgt:166cm
byr:1934
pid:232742206

ecl:amb hcl:#602927 eyr:2029
pid:897535300
hgt:189cm byr:1952
iyr:2017

pid:853604345
hgt:161cm cid:269
hcl:#fffffd eyr:2030 iyr:2011 ecl:grn byr:1966

hgt:151cm hcl:#18171d eyr:2026 ecl:grn iyr:2016 pid:176cm
byr:2000

hcl:#341e13
eyr:2022
pid:536989527 cid:73 byr:1971
ecl:hzl

pid:739005658 hcl:#b6652a
eyr:2026 hgt:154cm ecl:hzl
iyr:2019 byr:1935

pid:373465835 ecl:oth byr:1932 cid:333 hgt:165cm
hcl:#b6652a eyr:2021 iyr:2014

byr:1967 pid:486658617 hcl:#18171d hgt:174cm
eyr:2021 iyr:2015 ecl:gry cid:53

eyr:2024
cid:124 iyr:2017 hgt:152cm pid:095649305 hcl:#341e13
byr:1920 ecl:oth

hcl:#623a2f
byr:1951 pid:993284548
cid:106
hgt:186cm
ecl:amb iyr:2017 eyr:2029

cid:308 pid:080673934
hgt:193cm
byr:1967 hcl:#623a2f iyr:2016 ecl:hzl
eyr:2021

iyr:2010 eyr:2024 byr:1946 hgt:156cm
cid:199
ecl:blu hcl:#866857

ecl:blu byr:1955 eyr:2022 cid:95 pid:139391569
iyr:2019 hgt:180cm
hcl:#efcc98

ecl:brn pid:579889368
eyr:2023 hgt:158cm byr:1935
iyr:2018 hcl:#cfa07d

byr:1920 pid:90919899 hcl:#18171d
hgt:152cm
eyr:2029 ecl:oth iyr:2014

byr:1961 eyr:2024
ecl:#d401e3 iyr:2011 hgt:172cm pid:919145070
cid:100
hcl:#efcc98

ecl:gry
hgt:168cm
hcl:#888785 byr:1942 pid:731032830 iyr:2014
eyr:2028

hcl:#6b5442 pid:265747619 hgt:191cm
cid:217
eyr:2028
iyr:2019 ecl:amb
byr:1948

iyr:2011 ecl:brn
hgt:183cm hcl:#fffffd cid:258 byr:1983
pid:835909246

byr:2030
iyr:2024 ecl:#f66808
hcl:fd548d cid:183
pid:#fced33
hgt:160in

ecl:utc hgt:183in hcl:a92c31 pid:0394222041
iyr:2008
eyr:1976 byr:2020

pid:126195650 iyr:2019 hcl:#341e13
ecl:blu
hgt:150cm
eyr:2025
byr:1964

cid:71 iyr:2016 hgt:157 ecl:grt
hcl:#18171d pid:#1ab5ea eyr:2027

eyr:2026 hcl:#b5266f
byr:1971
cid:269 hgt:192cm iyr:2012
pid:736578840 ecl:amb

pid:152109472 hcl:#ceb3a1 ecl:grn hgt:188cm eyr:2027
byr:1923

hcl:#341e13 pid:535175953 hgt:63in eyr:2028 iyr:2015 byr:1999 ecl:gry

hgt:183cm pid:611738968 byr:2001
eyr:2020 hcl:#a97842 iyr:2014
ecl:gry

eyr:2038 ecl:gmt pid:113210210 iyr:2012 byr:2011
hcl:z
hgt:157cm

hgt:157cm
pid:699449127
iyr:2014 ecl:gry byr:1980 hcl:#fffffd eyr:2029

iyr:2028 hcl:z pid:152cm
eyr:2039
ecl:#4760fb hgt:177in
byr:2017

eyr:2026 hcl:#efcc98
iyr:2020 hgt:180cm ecl:hzl pid:747449965 byr:2016

byr:1974 iyr:2019
cid:89 eyr:2023 pid:421418405
hcl:#fffffd hgt:192cm
ecl:gry

hcl:26c2ef eyr:2029 cid:309 byr:1931 ecl:grn pid:#4eb099 iyr:2024
hgt:174cm

ecl:gry
hgt:183cm
cid:281
eyr:2022 pid:050492569
byr:1968 hcl:c88145
iyr:2015

eyr:2028
iyr:2014 pid:712984515 hgt:187cm cid:206 hcl:#866857 byr:1927
ecl:brn

byr:1936 hgt:61in ecl:oth iyr:2012 pid:447813841
hcl:#c0946f
cid:126 eyr:2021

ecl:gry pid:791970272
eyr:2020
byr:1932 hcl:#623a2f hgt:161cm
iyr:2015

hcl:#c0946f
byr:1935 pid:721144576 eyr:2025 hgt:162cm
iyr:2017 ecl:oth

byr:1959
pid:551109135
ecl:hzl hgt:68in
eyr:1977 hcl:#888785
iyr:1955 cid:100

hgt:190in eyr:1993 pid:8358180772 iyr:1975
ecl:oth
byr:2024
hcl:3de172

eyr:2030 hgt:190cm hcl:#a40ef3 byr:1935 pid:484932501
ecl:amb iyr:2016

iyr:2015
byr:1964
hgt:176cm
pid:819552732 hcl:#c0946f ecl:amb cid:263
eyr:2024

hgt:65cm cid:59 eyr:2027 pid:074880819 ecl:utc iyr:2023
byr:1954 hcl:#623a2f

byr:1954 hgt:167cm iyr:2020
eyr:2023 hcl:#602927
pid:280295309
ecl:hzl cid:168

hgt:168cm pid:311043701 iyr:2017 byr:1965
ecl:hzl
eyr:2026 hcl:#fffffd

hcl:#fffffd ecl:grn pid:672987232 iyr:2012 eyr:2022 hgt:66in

iyr:2012 ecl:#6f4f9f
hgt:133 byr:1937
eyr:1953 pid:7177768428 hcl:#602927

iyr:2010
byr:1922 hcl:#c0946f
eyr:2029 ecl:gry
hgt:165cm
pid:893045052

iyr:2013 eyr:2028 hcl:#866857 pid:137143403
ecl:brn hgt:170cm byr:1940 cid:194

hgt:161cm
eyr:2027 pid:3966920279 ecl:gry iyr:2015 byr:1997 hcl:#cfa07d

ecl:amb
hgt:157cm byr:1971
pid:562746894 cid:305 hcl:#0b0e1a eyr:2021 iyr:2016

hcl:8b821d hgt:157cm pid:187cm cid:298 eyr:1926 iyr:2019
ecl:amb
byr:2030

hgt:155cm hcl:#341e13 byr:1924 pid:779847670
ecl:hzl iyr:2015
eyr:2024

pid:768590475 hcl:#a97842 iyr:2014 cid:128 eyr:2029
ecl:oth hgt:164cm byr:1990

iyr:2019 hgt:181cm cid:342
eyr:2020 ecl:gry byr:2001
hcl:#623a2f
pid:473165431

byr:1928 eyr:2026 hcl:#42a9cb iyr:2010
ecl:grn hgt:157cm pid:638074984

eyr:2028
byr:1951
pid:239781647 iyr:2020 hgt:156cm
ecl:hzl cid:215 hcl:#efcc98

pid:636605355 ecl:hzl
iyr:2017 cid:323 eyr:2025
byr:1995
hcl:#18171d hgt:187cm

byr:1933 hcl:#866857 hgt:152cm ecl:oth iyr:2014 pid:900790914 eyr:2030 cid:267

ecl:brn byr:1999 eyr:2027 hcl:#623a2f iyr:2017
pid:853165955
hgt:152cm

eyr:2030 pid:316704688 hcl:#c0946f ecl:brn iyr:2014 hgt:193cm

iyr:2012 byr:1928
hgt:154cm pid:570535769 hcl:#623a2f eyr:2026 ecl:hzl

iyr:2016 cid:252 eyr:2030 hcl:#888785
hgt:177cm ecl:grn byr:2002 pid:568715162

pid:570999226 iyr:2012 hgt:150cm
byr:2024
ecl:brn hcl:z eyr:2029

pid:174002299 iyr:2019 hcl:#cfa07d ecl:brn byr:1927
cid:77 hgt:159cm eyr:2027

ecl:#d16191 eyr:2022 pid:166cm hgt:165cm hcl:#18171d iyr:2015

pid:112585759
hcl:#341e13 eyr:2025 byr:1962 hgt:164cm ecl:hzl iyr:2018

pid:478415905 eyr:2025 cid:315
ecl:amb hgt:91
iyr:2014 hcl:#cc9d80
byr:1985

pid:561885837 hcl:#7d3b0c
hgt:169cm
byr:1921 iyr:2014 cid:178
eyr:2022 ecl:gry

ecl:#c87497 hcl:5321a2 eyr:2020 hgt:74in
pid:#7a62c6 iyr:1976

eyr:2037
pid:858202391 hgt:162cm
ecl:grn byr:2003
cid:278
iyr:2010 hcl:cbf662

ecl:blu iyr:2012 hgt:183cm hcl:#623a2f pid:848200472 byr:1997 eyr:2027

byr:1942
hgt:164cm
pid:464257339
iyr:2016
hcl:#7d3b0c ecl:gry

iyr:2012 hcl:#ceb3a1
hgt:193cm ecl:amb
pid:667987561 eyr:2024 byr:1960

hgt:187cm
pid:222340640
iyr:2018 eyr:2022
ecl:oth
byr:1957
hcl:#336667 cid:83

eyr:2025 iyr:2015 hcl:#733820
ecl:brn
pid:131195653

hgt:185cm eyr:2026
ecl:amb byr:1998 pid:938587659 hcl:#733820
iyr:2016

ecl:oth pid:300949722
eyr:2028 iyr:2016
byr:1933
hgt:179cm
hcl:#cfa07d

byr:1974 iyr:2019
ecl:hzl hcl:#c0946f eyr:2024 pid:484547079
cid:112
hgt:185cm

eyr:2022 iyr:2018 hcl:#fffffd pid:118568279
hgt:153cm ecl:gry byr:1941 cid:341

iyr:2018
eyr:2027 hcl:#888785
byr:1970 hgt:165cm pid:773715893
ecl:amb

hcl:#623a2f hgt:156cm byr:1938 iyr:2012 pid:745046822
ecl:amb
eyr:2030

iyr:2012
pid:097961857
eyr:2023 hgt:66in hcl:#fffffd byr:1962 ecl:utc

byr:1943 hgt:150cm
iyr:2012
pid:740693353 eyr:2023
hcl:#18171d cid:101 ecl:blu

iyr:2018 pid:183728523 byr:1924 hgt:154cm eyr:2030
cid:167 ecl:blu hcl:#ceb3a1

hgt:69cm
eyr:2025 hcl:z ecl:brn byr:1982 pid:250782159
iyr:2011

byr:1998 iyr:2018 hcl:#341e13 eyr:2022 hgt:157cm pid:497100444 cid:266 ecl:gry

eyr:2027 iyr:2011 hcl:#6b5442 hgt:156cm pid:494073085
byr:1998
ecl:hzl

byr:1947 hcl:#b6652a
iyr:2011 pid:228986686 eyr:2030 hgt:175cm cid:70 ecl:brn

eyr:2026 hgt:159cm
byr:1946 pid:534291476
iyr:2018 ecl:gry cid:225
hcl:#18171d

pid:439665905
cid:311 ecl:amb iyr:2018
eyr:2030
hgt:186cm byr:1950
hcl:#cfa07d

pid:250175056 hcl:#efcc98
byr:1981 cid:262 hgt:154cm ecl:gry iyr:2020 eyr:2027

pid:461335515 iyr:2014 hcl:#f1cf00 hgt:180cm ecl:amb eyr:2027
byr:1956

iyr:2014 eyr:2030 cid:194
pid:234623720 hcl:#733820
hgt:164cm byr:1929
ecl:blu

byr:1992
eyr:2024 hcl:#ef8161 cid:216
ecl:brn hgt:177cm iyr:2018
pid:101726770

hcl:#341e13 hgt:178cm iyr:2016 eyr:2029 byr:1945 pid:045325957 ecl:grn cid:99

ecl:gry
iyr:2012
cid:52 hgt:168cm byr:1943
hcl:#cfa07d
pid:899608935 eyr:2030

cid:241
byr:1934 hgt:161cm eyr:2027 iyr:2011 hcl:#c0946f ecl:amb pid:346857644

iyr:2019 hgt:178cm
hcl:#c0946f byr:1957
eyr:2026
ecl:brn pid:222885240

ecl:blu
eyr:2021 cid:312 hcl:#733820 hgt:186cm iyr:2012 byr:1969
pid:821704316

hcl:#6b5442 cid:159
hgt:180cm
iyr:2018
eyr:2028
ecl:hzl byr:1966
pid:#e0238e

pid:622400994 eyr:2022 hcl:#5b6635 iyr:2012 byr:1980
hgt:190cm ecl:oth

byr:1976 ecl:gry eyr:2020 iyr:2020 hgt:171cm pid:219878671 hcl:#6b5442

hgt:163cm byr:1968
pid:003521394 ecl:oth
iyr:2010
cid:61 hcl:#888785

cid:115 pid:810722029 hgt:166cm byr:1955
ecl:blu eyr:2030 iyr:2018

hgt:176cm
eyr:2025
pid:617393532 hcl:#733820 byr:1975 iyr:2018 ecl:grn

hcl:#733820 byr:1979 pid:838168666
hgt:190cm ecl:oth cid:330
eyr:2029 iyr:2018

eyr:1940 hgt:67cm iyr:2009 ecl:gry pid:#e76a62 byr:2020 hcl:z

hgt:190cm ecl:brn pid:396113351
byr:1956 iyr:2010
hcl:#6b5442 eyr:2024
cid:256

hcl:#efcc98
hgt:178cm byr:1984 iyr:2013 pid:752620212 eyr:2021 ecl:gry

iyr:2014 hcl:#a97842
hgt:166cm ecl:blu eyr:2024
byr:1935
pid:836748873

cid:236 ecl:amb hgt:168cm iyr:2010 hcl:#602927 byr:1950 eyr:2026 pid:404810674

eyr:2030 ecl:grn
byr:1975 pid:064596263 hgt:193cm
iyr:2019 cid:71 hcl:#a97842

iyr:2014
pid:298386733 hcl:#c0946f
hgt:180cm ecl:hzl cid:115 byr:1940 eyr:2023

iyr:1960 hgt:139 ecl:#9db7b8 byr:1980 pid:#ef597b cid:54 eyr:2028 hcl:fdcda3

iyr:2015 byr:1954 ecl:blu hgt:62in hcl:#ceb3a1 pid:253593755 eyr:2028

eyr:2025 ecl:blu pid:216388098 iyr:2017 byr:1968 hgt:151cm hcl:#602927

eyr:2022 hcl:#a97842
pid:606979543 iyr:2013 ecl:grn cid:63
hgt:186cm byr:1992

ecl:gry
hgt:168cm hcl:#18171d iyr:2017 pid:670898814 byr:1983
eyr:2022

hgt:155cm ecl:grn iyr:2012 pid:837979074 eyr:2024 hcl:#888785 byr:1972

iyr:2015 pid:970743533 hcl:#866857 eyr:2027
byr:1921 ecl:brn

eyr:2022
hgt:160cm
byr:1964 hcl:#efcc98 iyr:2019 ecl:oth pid:141923637

byr:2029 pid:3313111652 ecl:brn eyr:2034
iyr:2013 hgt:193cm hcl:z

pid:853890227 eyr:2029
hcl:#efcc98 iyr:2021 byr:2003 ecl:#037c39 hgt:160cm

iyr:1927
byr:1992
eyr:2030
hcl:#efcc98
ecl:amb hgt:152cm pid:436765906

iyr:2014
hcl:#c0946f pid:207052381
eyr:2024 ecl:hzl
hgt:177cm
byr:1923

ecl:blu
iyr:2014
eyr:2025 hgt:165cm
hcl:#733820 pid:343011857 byr:1967

ecl:xry
eyr:2028
iyr:2011 hgt:166in hcl:#c0946f
pid:805297331
cid:167 byr:1926

byr:1947
pid:468012954 eyr:2026 ecl:oth iyr:2018 hgt:170cm hcl:#b6652a

hcl:#6b5442 ecl:brn
hgt:180cm cid:233
pid:029789713
byr:1920 iyr:2010 eyr:2024

iyr:2010 eyr:2027
hgt:156cm
hcl:#c0946f
byr:1960 pid:312723130 ecl:hzl

eyr:2023 byr:1959 iyr:2010 hgt:186cm pid:066768932 ecl:grn hcl:#602927 cid:310

eyr:2030 pid:460535178 hgt:171cm ecl:gry iyr:2020 byr:1934 hcl:#888785

hgt:64cm eyr:2021 byr:1995 cid:336
ecl:gmt pid:926714223 iyr:2017 hcl:#18171d

eyr:2022 iyr:2010
ecl:grn pid:285994301 cid:215
hgt:186cm byr:1978

hgt:63in hcl:#866857
pid:386128445 iyr:2020 byr:1971 eyr:2021 ecl:gry

hgt:183cm hcl:#733820 iyr:2015
ecl:blu pid:216205626 eyr:2022 byr:1941

cid:150 ecl:amb pid:872515243 byr:1926
eyr:1996
hcl:#dedc39 hgt:67in iyr:2020

byr:1927 ecl:brn cid:153 iyr:2011
pid:165190810 hcl:#fffffd
eyr:2028 hgt:64in

pid:502603734
byr:1966 iyr:2015 hgt:176cm cid:205 ecl:brn hcl:#fffffd eyr:2021

hcl:#18171d hgt:158cm byr:1943 iyr:2019
pid:058840094
eyr:2023

byr:1962 hcl:#b6652a ecl:grn
cid:297
iyr:2010 pid:990422650
hgt:154cm eyr:2020

eyr:1934 iyr:2011
ecl:gry
hcl:z byr:2004 hgt:63cm pid:6173356201

pid:329432364 eyr:2029
ecl:grn hcl:#18171d iyr:2013
hgt:158cm byr:1960

hcl:#efcc98 iyr:2016 hgt:186cm cid:215
pid:852781253 eyr:2027 ecl:blu byr:1937

hcl:#623a2f ecl:gry iyr:2020 byr:1972 hgt:182cm pid:073426952 eyr:2027

hcl:#3317b9 byr:1950 pid:304511418 hgt:177cm cid:124 eyr:2020 ecl:hzl iyr:2014

eyr:2029
pid:034754507 byr:1936
cid:265 ecl:#b50997 hgt:183cm
hcl:#623a2f iyr:1924

eyr:2024 byr:1927 cid:243 ecl:gry hcl:#6b5442 pid:714355627 hgt:160cm
iyr:2016

hgt:152cm
ecl:gry hcl:#a97842
eyr:2029 byr:1952
pid:555308923 iyr:2010

byr:2008
pid:19681314 hgt:180in iyr:2030 ecl:gry cid:272
eyr:2023
hcl:#b6652a

cid:234
iyr:2014 byr:1940 ecl:hzl pid:042231105 hcl:#3bf69c hgt:172cm eyr:2029

hcl:#efcc98 pid:831567586 hgt:190cm iyr:2017
byr:1966 eyr:2024 ecl:blu

hcl:#341e13 ecl:blu
eyr:2022 cid:161 pid:197839646 iyr:2014

hcl:#cfa07d
byr:1957
iyr:2019 hgt:181cm
pid:543775141 ecl:oth eyr:2021

hcl:z
pid:#596c41 eyr:2035
byr:2008 iyr:1975
ecl:#c66ee6
hgt:150in

ecl:grn
hcl:#7d3b0c iyr:2016
pid:804255369 eyr:2028 byr:1983 hgt:69in cid:82

eyr:2022
iyr:2013 hgt:191cm ecl:gry
hcl:#a97842 pid:186827268 byr:1969

pid:871672398 eyr:2026 byr:1946 ecl:oth
iyr:2015
hcl:#866857 hgt:185cm

byr:1973
hgt:150cm
pid:905076707
iyr:2017
hcl:#2edf01 ecl:oth cid:221 eyr:2026

eyr:2024 ecl:grn pid:955444191 hcl:z iyr:2015 byr:2008 hgt:151cm

byr:1958 hcl:#fffffd pid:218986541 cid:203 ecl:brn hgt:154cm
iyr:2014
eyr:2026

hcl:#623a2f byr:1964 ecl:oth iyr:2010 pid:525843363 hgt:164cm eyr:2025

ecl:blu iyr:2013 hgt:193cm byr:1990 pid:612387132 hcl:#18171d cid:280 eyr:2028

ecl:oth eyr:2022
pid:110447037 hgt:187cm byr:1967 hcl:#efcc98

byr:1930
eyr:2026 hgt:159cm
iyr:2011
ecl:hzl hcl:#6b5442 pid:923471212

cid:350
eyr:2029 pid:823592758 iyr:2018
ecl:grn byr:1972 hgt:167cm hcl:#18171d

cid:76 eyr:2027 hcl:#6b5442 pid:099579798 byr:1930
iyr:2020
ecl:gry hgt:153cm

byr:1957 ecl:brn
hcl:z iyr:2016 pid:352677969 hgt:189cm
eyr:2029

cid:143 eyr:2035 pid:602952079
ecl:#9b73f0 hcl:#602927
iyr:2022 byr:1975
hgt:174cm

byr:1971 pid:741305897 hgt:192cm
ecl:amb hcl:#888785 eyr:2028 iyr:2011

ecl:oth iyr:2016
byr:1942 hgt:189cm hcl:#888785 eyr:2024 pid:054290182

hcl:#a97842
byr:1945
ecl:amb pid:370849304
eyr:2028
iyr:2016 hgt:168cm

hgt:154cm iyr:2015 eyr:2030 byr:1952 ecl:hzl hcl:#341e13 pid:996518075

byr:1941 ecl:amb iyr:2014
hcl:#fffffd pid:560990286 eyr:2022 hgt:173cm

ecl:blu byr:1974
hgt:150cm hcl:#ceb3a1 eyr:2020 iyr:2013
pid:827415351

hcl:#623a2f eyr:2027 iyr:2011 pid:913199234 ecl:oth
byr:1990 hgt:178cm

ecl:blu byr:1989 hcl:#b6652a
eyr:2026 pid:724881482 hgt:185cm iyr:2014

cid:115 pid:255002731 eyr:2025 ecl:amb
byr:1934 iyr:2020 hcl:#7d3b0c

hgt:150cm byr:1969 ecl:blu iyr:2023
hcl:#866857 pid:754288625 eyr:2029

iyr:2011 hcl:#7d3b0c ecl:hzl
byr:1930
hgt:188cm
eyr:2023
pid:256556076 cid:136

iyr:2025 byr:1978
ecl:#fe30a9 hcl:#efcc98 eyr:2029
pid:392032459 hgt:178cm

eyr:2027 iyr:2017 hgt:160in
byr:1990 pid:131099122 hcl:#623a2f ecl:amb

ecl:grn
byr:1978
eyr:2029 hcl:#18171d
hgt:165cm pid:172369888
cid:93
iyr:2011

ecl:hzl
hcl:#733820 iyr:2010 eyr:2029 pid:127253449
hgt:156cm
byr:1963

hcl:#6c8530
iyr:2020
byr:1929 eyr:2021 hgt:177cm ecl:oth pid:347925482

eyr:2037 iyr:2026
pid:163cm
hgt:174in byr:2007 hcl:c1305f cid:134
ecl:#0cf85c

iyr:2011 pid:033811215
hcl:#a97842 byr:2002 eyr:2021 hgt:186cm
ecl:brn

hcl:#a97842
iyr:2020 eyr:2029 byr:1972 pid:535511110 hgt:160cm ecl:oth

ecl:grn cid:89 hgt:193cm pid:73793987 iyr:2021 eyr:2027 byr:1939 hcl:z

hcl:#623a2f
hgt:182cm cid:154
pid:873863966 iyr:2018 byr:1999 ecl:brn eyr:2031

iyr:2014 eyr:2029
cid:71 hcl:#fffffd byr:1924 hgt:63in
ecl:gry pid:897972798

hgt:76cm
hcl:z eyr:1955
iyr:2012 byr:2001 pid:9425090 ecl:hzl

eyr:2021
pid:501861442
ecl:grn hcl:#d71ae9
byr:1977
hgt:167cm iyr:2015

iyr:2014
hgt:170cm ecl:gry byr:1928 cid:314 hcl:#602927 eyr:2029
pid:836710987

eyr:2027 hcl:#efcc98 ecl:amb iyr:2016 byr:1995 pid:603705616 hgt:179cm

eyr:2030 hcl:#602927 cid:105 byr:1943 ecl:hzl
pid:381601507
hgt:188cm iyr:2020

iyr:2011
byr:1993 hcl:#c0946f pid:292649640 hgt:139 ecl:hzl cid:268
eyr:1999

cid:339 byr:1928
ecl:brn eyr:2022 hcl:#733820 hgt:191cm pid:282733347 iyr:2019

hgt:176cm
byr:1935 ecl:brn cid:252 eyr:2023 pid:105060622 iyr:2020 hcl:#18171d

ecl:hzl eyr:2029
hgt:193cm pid:770254253
hcl:#efcc98 iyr:2020 byr:1926

pid:977785261 eyr:2022 iyr:2015 byr:1978
hcl:#733820 hgt:172cm
ecl:brn

byr:2021
hgt:160in
ecl:gmt
eyr:2032 cid:345 pid:179cm
hcl:8f5c13 iyr:2029

iyr:2018 hgt:182cm ecl:gry
pid:897076789 eyr:2023 hcl:#866857
byr:1980

hgt:88 eyr:2039 cid:99 byr:2007 hcl:a1bb42 ecl:#a2f6bb
pid:2264966188
iyr:2022

iyr:2012 cid:59 ecl:gry eyr:2021
byr:1931
hgt:172cm hcl:#7d3b0c pid:862416147

byr:1962 eyr:2025
ecl:grn
hcl:#866857 hgt:180cm iyr:2014 pid:313647071

eyr:2030 hgt:157cm byr:1985
iyr:2020
hcl:#7d3b0c pid:911544768
ecl:grn

hgt:175cm
byr:1938
iyr:2020 ecl:amb hcl:#602927 eyr:2026 pid:144411560

iyr:2019 ecl:amb hcl:#888785 eyr:2025 hgt:187cm
pid:942054361 byr:1939

cid:168 pid:722146139 byr:1952 ecl:grn
iyr:2014 hgt:97
hcl:z
eyr:2023

eyr:2024 pid:567528498 ecl:gry iyr:2012 byr:1990
hcl:#733820 hgt:193cm
cid:293

hcl:#bc352c pid:321838059 byr:1930 hgt:178cm cid:213 eyr:2023 ecl:amb
iyr:2017

hgt:173cm byr:1925 pid:070222017 iyr:2013 hcl:#ceb3a1 ecl:gry eyr:2024";

        public static string Day5SampleInput => "FBFBBFFRLR";

        public static string[] Day5() => RawConverter(Day5Raw, new[] { Environment.NewLine });
        private static string Day5Raw => @"BBFFBFBRLL
FFFFBFBRLR
BFFBBFBRLR
BFBBBFBLLL
FFBBFBBLRR
BFBFFFFRRL
BBBBFFFRLR
BFFFBBFRLL
FFFFBFBRRL
BFBBFFFRRL
BBFBBBFRLL
FBFFBFFRLL
FBBBBBBLRL
FFFBBFBLRL
FFBBFFFLLR
FBBFFFBLLL
FFBFBBBRRL
FBFBBBFRRL
FFBBBFFLRL
BFBBBBFRLR
FBBBFFBRRL
FBBFBFFRLL
FBFBFBBLLL
BFBFFFFLRR
FFFBBFFLLL
FFFFBFFRLL
FBBBBFBRRR
FBBFBBBLRL
BBBBFFFLLL
FFFFBFBLLR
BFFFFBBRLL
BFFFFBBRLR
BFFFFFBRLL
BFFBBBFRRL
FBFFBBBLRR
BFBFFBFRRR
BBBBFFBLRR
FFFFFBBRLR
BFFFBBBRLR
BBFBFFBRRL
FBBFBFBLRR
BFBBFBFRLR
FFFFFBFRRR
BFFFFFBLRL
FFFBFBBLLR
BFFFBBBLRR
FFBFFBBRRL
FBBBBBBLLL
FBBBBFBLRL
BBFFFBFRRL
BBFFFBBRRL
FFBFBFBLRL
FFFFBBBRLR
FBBFFBFLRL
FBBBBFBRLR
BBFBFBBLRL
BBBBFFFLRR
BFBBFFBRLL
BFBBFBBRLR
FFFBBFBRRR
BFFBBBFRRR
BFBBFBBLRR
FBBFFBBLRL
FFFBFBBRRL
BFFFBFBRRR
FBBBFFBLRR
BBFFBBBLLR
BFFBBBBRLR
BBBBFBFRRR
BBBBFFFRRL
BBFFBBBRRL
FFBBBBBRRL
FFFFBBFRRL
BFFFFFBLLL
FFBFFBBLRL
FFFBBFFLRL
BFBFBFFLLR
FFFFBFFRRL
FBBBBFFRLR
FBBBBFBRRL
FBBBFBFLLR
FBBBBBBRRR
FBBFFFFRRL
FBFBFFFRLL
BBFFFBFRLL
BFFBFFFRLL
FFFFBFFLRL
FBBFFFFLLR
BBBBFFBRLL
FBFBFBBRLL
BBFBBBFLLL
FFBFBBBRRR
BFBBFBFRRR
BFBFBBFLRR
BBFBBBFLRL
BBFFFBBLRL
FBFFFBFRLR
FFBFFBBRLL
FFBFFBFRLR
BBBFBFFLLR
BBFBFBBLRR
FBBBBFFLLR
BFFBFBFLRL
FFFBFFFLRR
FBBFBBBRRL
FBFBBBBRRL
BFBFBBFLLL
BFBFBBFRLL
FBFBFFBLLR
FBFFFFBRLR
BBFBBBFRRL
BBBFFFFLLL
FFFFBFBLRL
FFBFFFBLLR
FFFBBBBRRL
FFBFFFBLRL
BBBBFBFRRL
FFFBFFFLLR
BBBBFBBRLR
BBFBBBBRRL
FBFBFFBRLL
FBBBFBFRLL
BFFBFBBRLR
FBFBFBBLRR
FBBFFFBLRR
FFFBBFFRLR
BBBFFFBRLR
BBFFBFFLLL
BFFFFBBLLR
BFBFBBFLRL
FFBFBFBRLL
FBBFBFBRRL
BBBFBFFLLL
FFBBFFFRRR
BFFBBFBLLL
BBBFFBFLLR
FFFBFBBLLL
FFBFBFFRLL
BFFBBBBLRL
FBFBBFFLRL
FBFFBFBLRL
BFBBBBFLRR
BBBFBFFRRR
FBFBBFFRLR
BFBBFFFLLR
BFFFBFBLRR
FBFBFBBRLR
FFFFFBFRLR
FFFFBBBRRL
FBBFFBFLLL
FBBBBBBRLR
FBBFFFBRLR
FBBBFBBRLL
FFFBFBFRLL
BFBFBBFLLR
FFBFFBFRRL
BBFBBBFRLR
FFBBBBBLRL
BBFBBFBRLL
FFBFFFBRLL
FFBBBFFRLR
BFFBBBFLRL
FFBFBFBRRL
FBBFFFBRRR
BBFBBFFLLL
FBFFFFFRLL
FBFFFFBLRL
FFFBFFBRRR
BBBFBFBRLL
BBBBFBBRLL
BFFBFBBLLR
BBBFFFBLRL
BFFBFFBRLL
BFFBBFBRRL
FBFFFFFRRL
FFBBFBBRRR
BBFFBBFLLR
FFBFFBBLRR
BBBFBFFLRL
BBBBBFFLLL
FFBBBBBLRR
BFFBFFBRLR
BFFBBFBLRL
BBFFBBFRRL
FFFBFFBRLR
BFBFBBBLLR
BFFBFFFLLL
FBBFBBBRLR
BFBFBBBRRL
FBFBFFBRRL
BBBFBFBLRL
BFFFBBBLLR
FBBBFBFLRR
FFBBBBBRLR
FFBFFBBLLL
BBFFBFBLRL
BFBFBFBRRL
BFBFFBFLRR
FFBBBFBLLR
BFBFBBBRRR
FBFFBBFLRR
BBBFBFFRLR
BFFFFBFRLL
FFFFBBFLRL
FBBBBFBLLR
BFBFFFFLLR
FFBBFBBRLL
FBFBBFFRRL
BFFFBBFLRR
BBBFFBFLRR
FBBBFFFLRR
BBFFFBFRLR
FFFBFBBRLR
FFBBFBBLRL
FBFFBBBRRR
BBFBBBBLLR
BFFFFFBRLR
BBFBFBFRLR
FBFBBBFLRR
BBFFFBBLLL
BBBFBFBLLR
BFFBBFFLRL
FFBFFFFRLR
BFFFFFBRRR
FFBBBFBLRR
BBBFBBBLRR
BBBBBFFLRL
FBFFFBFRRR
BFFFFFBLLR
FFBBFBFLRL
BBFFFBFRRR
BBBFBFBRLR
BBFBBFBLRL
FFFBFFBLRL
FFFBFFBRLL
BBBBFFFRLL
FBBFFFFLRR
FFBBFFBLLR
FBFFBFBRLL
FFBFBFFLLL
BFBBFFBLRR
BFBFFFBRLR
BBBFFBFRRL
FFBBFBBRLR
BBFFFFBRLL
BBFFBFBLLR
BBFFBFBRRL
FBBBFBBRRL
FFFFFBBRLL
FBFFFBFRRL
FBBFBFFLRL
FBFBBBFRLL
BFFFBFFLRR
BFFBBFBRRR
BFBBFBBLLL
BBFBFFFLRL
BFBFFFFRRR
FBBFBBBLRR
FFBBBBBLLR
FFFFBBFRRR
FFBBFFBRRR
BBFFFBBLLR
BFFBFFBLLR
BBBFFFFRLL
FFFBFBFLLR
BBFBFFBLRL
FFBBBFBRRL
BBFBBBBRRR
BBFBBFBRRR
FFFFBFBRLL
FFFBFFBLLR
FFBFBBBLLR
FBBBFBFLRL
BFBBBBBLLL
BFBBFBFRLL
BFBFBBBLRR
FFBFBFBLLL
BFBFFFBLLR
BBBBFBBRRL
FFBFFBFLRR
FBFBBFFLLL
BFBFBBBRLL
BFBFFFBRRR
FBBFBBFRRR
BFFBFBFRLL
BBFFFFBRRL
BFBFBFBLRL
FBBBFFBRRR
FFFFBBBLLR
BBBFFFFRRR
BBBFFFFLRR
FFBFBBFLLL
BFBFBFFRRR
BBFFFBBRLR
FBBBBBFLRR
FBFFBFBLLR
FFBFFFBLLL
BFFFFBBLRL
BBBFBBBRRR
BBBFFFBRRL
BFFFFBBLRR
BBFFBBBRLL
BFBFFFFLRL
BBFFFFFLRR
BBFFFBFLRR
FBFFBBFRRL
BFFFBBBLLL
BFBBBFFRRL
BFFFBFBLRL
FBBBBFFRLL
BFBFBBBLLL
BFBBFFBLLR
BBBBFBBLLL
FBFBFBFLRR
FBBBFFFRLR
BFFBFBFRRL
BFBBFFFRLR
FBBBFFFLRL
FBBBBFFLRR
FBFFFFBLLL
BBBFFBBRLL
FBBFBFFLLL
BFFBBFBRLL
BFFFFBFRLR
FFFBBFFRRR
FFFBBBFRLR
FBBFFBFRRR
FBFFFFBRRR
BFBFBFBRLL
BBBBBFFRLL
BFFFFBFLLL
BBFFBBFRRR
BFBFFFBLLL
FFFBFBFRRR
FBFBBFBRRL
BFBFFFBRRL
FFFBBBBRRR
BFBFFBBLLR
FBBBFBBLLR
BBFBBFBLLR
BFFFFFFLLL
FBBFBFFRLR
FFBBBBFLLL
BFBBFBFLRL
BFBFBFBLLL
FBBBFBBLLL
BFBFBFBRRR
FBFBFFFLRR
FBFBBFBLLL
FBFFFFBLRR
BBBFFBFRLL
FFFBFFBRRL
BBFBFBFRRR
FBBFFBFRLL
BBBFBBFRRR
FBFBBFFLRR
BBFBBBBLLL
FFBFFBBLLR
FBBBFFFRRR
FFFFFBBLLL
FBFFBBBRRL
BFFBBBFRLL
BFFFBFFLLR
FBFFBBBLLL
FFFBBBBRLR
BFBBBFFLLR
FBFBBBBLLR
FBBFBFBRRR
BBFFBFFRRR
FBBFFFFLRL
FBFBBBBLRR
FFBBFBFRRR
FBFBBFBRLR
BBFBFBFRRL
FBBBBBFLLL
FBFFBFFLLR
FBFBFBFLLL
BFFBFBFLRR
FBBBBBFRLL
BFFBBBFRLR
BBFFFFFLLL
FFFFBBFRLR
BFBBBBBLLR
BBFFFBBRLL
FBFFFFFLRR
BBBFFBBRRR
FFFBFFBLRR
BFFFFFFRLL
BBFFFBFLLR
BFFBBFFLLL
FBBBFFFRRL
BBBBFBFLLL
FBBFFFFRLL
FBFBBFBRRR
BFFFFFFRLR
BFBFFFFLLL
FBFBBFBLLR
BFBBFBFLLR
BFBBFBBLRL
BFFFBFFRLR
BBFBBFFRRR
FBFBFBFRLL
FFBBFBFRRL
BFFFBFFLRL
FBFFBBBLRL
BBBFFBFLRL
FFBBBFBRRR
BFFFBFBRRL
FFBBFBFLLR
BFFBFFFLRL
BBBFFFFLRL
FFBBFFBRLR
BFFBFBBRRR
BFFBFFBLRR
BFFFBBBLRL
FFBFBFFRRR
FFBFBBFRRL
FFBBBBFRLR
BBBFBBFLRR
BFBBFFFLRL
BFBBBBFRRR
FFBFFFBLRR
FFBFBFFLLR
FBFFBFBRRL
BFFFFFFLRR
FBBBBBBLRR
BBFFBBFLLL
BFBBBBFRRL
FFBFFFFLLR
BBFFFBFLLL
FFBFBFFLRR
FFBBBBFLRL
FFFBBBFRRR
FBBFFBFLRR
FBFBBBBRLL
FFFBBBBLLL
FFBBBBFRRL
FBBBBBBLLR
FBBFBFFLLR
BFBBFBFRRL
BBFFBFBLRR
FBFFBFFRRR
FFFBBBBRLL
BFFFFFFLLR
BFFFFBFLLR
FFFBBBFRRL
BFFBFFFLLR
FBFFFFFLLL
BBBBFBBLRR
BBFFBFFRRL
BFBBFFBLRL
FBBBBFFRRR
FFFBBFBLLR
FBBFFFFRLR
FFFBFBBLRL
BFBBBBFLLR
BBFFFBBRRR
BFBFBBFRRR
FFFBFFFRRL
BBFBFBFRLL
FBFFBFFRLR
BFFBFFBLLL
FFFFBFBRRR
BFFBBFFRLR
FBBBFBBLRL
FBFFBBBRLL
FBBBBBFRLR
FBBBFFBLLR
FBFBBFFRLL
FFBBBFFRRL
BBFBBBBLRR
BFFFFBBRRL
BFFFBFFRRL
FBBFBBFRRL
BFBBFFBRLR
BFFFFBFLRL
BBFFFFBLLR
FBFFFFFRRR
FFFFBBBRLL
FFFFBBFLLR
BBBFBBBLLR
FFBFFFFRLL
FBBBFFFLLR
FFFFBBBLRL
FBFBBBFLLL
FBFFFBFLLL
BBBFFBBLRR
FBBBFFFLLL
BBFBBFFRLR
FFFFBFFLLL
BBFFBFFLLR
BFBBBBFRLL
BFFBBFFRLL
BBFFFFBRLR
FBBBBFBRLL
BFBBFFBLLL
FBBFFFFLLL
FFBFFBBRRR
FBFFBBBLLR
BFBBBFBLRL
BBFFBBFRLR
FFBBBFFRRR
BBBBFBFRLL
BFFFBBBRRR
BBFFFFFRLR
FBFBFFFLLR
BBFFBBFRLL
BFFBBFFLLR
FFFFBBBRRR
FFFBFBFRRL
BBBFBBFRRL
FBBBFBBRLR
FBFBFFFRRR
BFFBBBBLLR
BBBFBFBLRR
FBFBBFBLRR
BBBFFBBRLR
FBFBFBBLRL
BBBFFBBLLR
BBFBFBBRLL
FBBBFFBRLL
FFBBFFFRLL
FBFFBFFRRL
BBBBFFBRRR
FBFBFFFLLL
FFFFBBFRLL
BFFBFFFRRR
BBFFBFBRLR
FFBBBFBRLL
BBFBFFFLLL
FBBFBBFRLR
FFFBFFFRLL
FBBFFBFRRL
BFBFFBFLRL
BBBFFFFRRL
BBFFBBBRRR
FFBFBFFRLR
FFBBFFFRLR
FBFBFBBRRL
FFBBFBBLLR
FBFFFFFRLR
BBBBFBBLRL
BBFFBFFRLL
FBBBFBFLLL
BBBFBFBLLL
BFFBFFFLRR
BFBFFBFRLL
BFBBBBFLRL
BBBBFFFLRL
FFFBFFBLLL
FFFFBFBLRR
FFFFFBBRRR
FFFBFBBLRR
BFFFBBFRRL
FFBFBBFLRR
BBFBBBBRLL
FBBBBBFRRR
BFFFFBFLRR
BFBFFBBRRL
FBFBBFBLRL
BBBFFBBLLL
FFBBBFFLRR
BBBBFBFLRL
BBBBFFBLLL
BFFFBBBRLL
FBBFFFBLLR
BFBBBFFRLL
FBBFFBFRLR
BBFBBFBRRL
BFBBFBBRLL
BBFBFFFRRR
FBBBFFBRLR
BBFFBBBLLL
BFFFBFBLLR
BBFBFFBRLR
FFBFFFBRRL
FFBFBFBRLR
BBFFBFBLLL
BFBFBBBRLR
FBFFFBFLRL
BFBFFFFRLR
BBFFFFFRLL
BBBFFFBRRR
FBFFBBFRRR
FFFBBFFLLR
FFFBFBFRLR
FFBBBBFLRR
BFFFBFBRLR
FFBFFBBRLR
FBBFFFBRLL
FBBFBFFLRR
BFFFFFFRRR
BBBFBBBRLL
FBFFFBBRRL
FFBBBFBLRL
FBFFBFBLLL
FFFFBFFRLR
FBFFBFFLRL
FFBFBFFRRL
FBBBFFBLLL
BFFFFBBRRR
BBBBFFBLLR
FFFFFBBLRL
FFBBBFFLLR
FBBBFFFRLL
FFBFFBFRRR
BBBBFFBRLR
FFBBFBFLRR
BFBBBBBRLL
BFBBBBBLRL
FFBFBBFRLR
FFBFBBBRLL
BFFBBFBLLR
BFBFFFFRLL
BBFBBFFRRL
BFBFFBFRLR
FFBBFFFLRL
FFBBBFFLLL
BFFBFBFLLL
BFBFBFBRLR
FBBFBFBLLR
BFBFFBBLRR
FFFFBFFLRR
BBFBBFBLLL
FBFFFFFLRL
BBBBFBFRLR
BFFFBBFRRR
BBFBBFFLRR
BFBBBFBRLL
BFFBFFBLRL
BFBFFFBLRR
BFFFBFFRRR
FBFFFBBLLL
FBFBBBBLRL
FBFBFFFRLR
BBFFBBFLRL
BFBFBFBLLR
FBFFFBFLRR
BFFBFBBRRL
FBFBBBFLLR
FBFBFFBLRL
BBFBFBBRRR
FBBFFBBLRR
BBFFFFBLLL
FBFFBBBRLR
FBFFFBFLLR
BFBBFFFLLL
BBBBFBFLRR
BFFBFBBRLL
BFFFFFFRRL
BFBFBFFRRL
FFBFBFBLRR
FFFBFBFLRR
FFFBFBBRRR
FBFFFBBRLR
FFBBFFBRRL
BBFBBBBRLR
FFFBBFBRLR
FBFFBBFLRL
BBBFFFBRLL
BBBFBBBRLR
FFBFFFFRRR
FBBFBFBLLL
BFBBBFBRRR
BFBBFFBRRL
FFFBBBFLLL
FBBBBFBLLL
FFBFBFBLLR
BFFBFFFRLR
BBBBFBFLLR
FBBFBBFLLL
FBFFFBBLRR
FFBFBBFRRR
FBFBFBBRRR
FFBFBFBRRR
FFBBFBFRLL
FBFBBBBLLL
BFBFFBBLLL
BBBFFFFRLR
BBBFBFBRRR
BFBFBFBLRR
BFBFBBFRLR
BFBBBFFLLL
FBBFFBBRRR
BFFFFFBLRR
BFFBFBFRLR
BBFFBFFRLR
BFBBBBBLRR
FBFFFBBLRL
BFFBFBFRRR
BFFFFBFRRL
FFBFBBBLLL
FBBBFBFRLR
FFFBBFBLLL
FBFBBBFRLR
BFBFFFBRLL
BFFBBBBLRR
BBFFBFFLRL
BBBFBBFRLL
BBBFFFBLRR
FBBFFBBRLR
FBBFBBFLRR
BBFBFBBRRL
FFBBBBBLLL
BFBBFBBLLR
BFBBBFFLRR
BBBFFFBLLL
FBFBBBBRLR
FBFBFFBLRR
FFFBBBFLRL
BBBFFBBLRL
FBBFBFBRLL
BBBBFBBLLR
FFBBBBBRRR
BBBFBBFLRL
BFBBBFBRLR
FFFBFFFRRR
BFFFBBFRLR
FBFFFFBRLL
BFFBFFBRRL
BBBFBBBRRL
FFBFFBFRLL
FBFBBFFRRR
FFBFFFBRLR
FFFFBFFLLR
FFBBFFFLLL
FBFFFBBLLR
FFBFBBFLRL
BFFBFBBLLL
FBBBFBBLRR
FFFBFBFLLL
FBBFBFBLRL
FFBBFFFRRL
BFBFBFFRLL
BFFFFBFRRR
BBBBFFFRRR
BFFBFFBRRR
FFFFBFFRRR
FFBBFBBRRL
FBBFBBBRLL
BBBBFFBLRL
FBBFBBFRLL
BFFBBBBRLL
BFBBBFBRRL
BBFBFBFLLR
FFFBBBBLLR
BFFBBFFLRR
BBBFBBBLRL
FBBFBFFRRL
BBFBFFFRRL
BBFBFFBLRR
BBBFBBFRLR
FBBBFBFRRR
BBFBFBFLRL
FBBFBBFLRL
FFBFFFFLRR
BFBBFBBRRL
FBBBBFFRRL
FBFBFFBRRR
BBBFFBFLLL
FFFBFFFLRL
FBFBBBFRRR
BBBFBFFRRL
BFBFFFBLRL
BBBFBFFLRR
BFFFBFFLLL
FFBFBBFLLR
FFBFBBFRLL
FBFBBBFLRL
BFFBBBBRRL
FBBBFBFRRL
FFBBBFBLLL
BFBBBFFLRL
BBBBBFFLLR
FBFBFFFRRL
BFFBFBBLRR
BBFFFFBLRR
FBFFBFBLRR
FBFFBBFRLR
FFBBFFBLRL
FFFFFBBLRR
BBBBBFFLRR
BFBBBBFLLL
FBBFBFFRRR
FFFFFBBLLR
FFBFFBFLLL
FFBFBBBLRR
FFBBFBFRLR
BFBBBFFRRR
FBFFBFBRLR
BBBFBBFLLR
BFBBFBFLRR
FBBBFFBLRL
BFBBBBBRLR
FBBFBBFLLR
BFBBBFFRLR
FBBBBBFLRL
BFBBBBBRRR
BFFBBBBRRR
BBFBFBFLRR
BFFBBBBLLL
BBFFFBFLRL
BFBBFBFLLL
FBFFFFBRRL
FFBBBBFRRR
FFBFBBBRLR
BBFBFBFLLL
FBFFBFBRRR
FFFBBBFLLR
FFFBFBFLRL
BFBFBBBLRL
FBBFFBBLLL
BBBFBFBRRL
FBFFFBBRRR
BFFFBFBLLL
FFFFBFBLLL
FFFBBFBRLL
FBBFFFBRRL
FFBBFBFLLL
FFBBFFBRLL
FBFBFBFLLR
BBFFFFBLRL
BFBFBBFRRL
FFFBFBBRLL
FBBFFBBRLL
BBFBFBBLLR
BFFFBFFRLL
BFBFBFFLRR
FBFFFFBLLR
FFFBBFBRRL
FFFBBBBLRL
FFBBFFBLRR
BFFFBBFLLL
FFFBFFFLLL
FBFBFBFRRR
BFBBBFBLLR
BFFBFFFRRL
FFFFBBFLRR
FBFBFBFRRL
BFBBFBBRRR
BFBFFBBLRL
FBFBBFBRLL
FBBBBFFLRL
FFBFBFFLRL
FBBFBBBRRR
FBFBFBFRLR
FFBFFFFLRL
BBFBFBBRLR
BFBFFBBRLL
BBFFBFBRRR
BFBBBBBRRL
BBFBBBFLLR
BBFFBBBRLR
BBFBFFFLLR
FFFFBBFLLL
FBBFFFFRRR
BBFBFFBRLL
FFBBFBBLLL
BFBBFFFRRR
BFBBFFFRLL
BFFBBFFRRL
BBFBBBFRRR
BFFFBFBRLL
BFFFBBBRRL
FBFBBFFLLR
FBFFBBFRLL
BBFBBFBLRR
BBBFFFFLLR
FBBFBBBLLL
FBFFBBFLLL
BFFBFBBLRL
BBFFFFFRRL
FFBBBBBRLL
FBFFBFFLLL
FFFFFBFRRL
BBBBFFBRRL
FBBFBFBRLR
BBFBBFBRLR
BFFBBFBLRR
BFFFFBBLLL
BBBBFBBRRR
BBBFFFBLLR
FFBFFFFLLL
FBBFFBFLLR
BBFFFFFLRL
FFFFBBBLRR
FBBBBFFLLL
FFBBFFBLLL
BBFBFFBRRR
FBFBFBFLRL
FFFBBBFLRR
BFBBBFBLRR
FBBBBBFLLR
BBFFBBBLRL
FFBFFBFLLR
FFFBBBFRLL
FBFFFBBRLL
BFFBFBFLLR
FFBBBFBRLR
BBFFFBBLRR
BFFFBBFLRL
FFFBBFFLRR
BBBFBBBLLL
BBFBFFFRLL
FFFBBFFRRL
BFBBFFFLRR
BBFFFFBRRR
BBFFFFFLLR
BBFBBBBLRL
FFBFBBBLRL
BBFFFFFRRR
FBFBFFBLLL
BFFBBBFLRR
FFFFFBBRRL
BFFFFFBRRL
BBBFBFFRLL
FBFFBBFLLR
BBBFFBFRRR
BBFBFFFLRR
BBFFBBFLRR
BFBFFBFRRL
FBBBFBBRRR
BBFFBFFLRR
BBFBFFFRLR
FBBBBBFRRL
BFFFBBFLLR
BBFBBFFLLR
FBFFFFFLLR
FFFBBFFRLL
BBFBBFFRLL
FFFFBBBLLL
BFBFFBBRLR
FBBFBBBLLR
BFFBBBFLLR
BFFFFFFLRL
BFFBBBFLLL
BFBFFBFLLL
BBFBFFBLLL
FFBBBBFRLL
FBFFBFFLRR
BBBFFBBRRL
BFFBBFFRRR
BBBBFFFLLR
BFBBFFBRRR
FBFFFBFRLL
FFBBBFFRLL
FBBBBFBLRR
FFFBBFBLRR
FFBBFFFLRR
BBFBBBFLRR
FBFBFFBRLR
FBBFFBBLLR
BBFFBBBLRR
BBFBFFBLLR
FBBFFFBLRL
BFBFBFFLRL
FFFBFFFRLR
FBFBFFFLRL
BBBFFBFRLR
BBBFBBFLLL
FBFBFBBLLR
BFBFBFFLLL
FFBFFFBRRR
BFBFBFFRLR
FFFBBBBLRR
BBFBBFFLRL
FFBFFFFRRL
BFBFFBFLLR
FFBBBBFLLR
FBFBBBBRRR
FFBFFBFLRL
FBBBBBBRLL
BBFBFBBLLL
FBBFFBBRRL
FBBBBBBRRL";

        public static string[] Day6() => RawConverter(Day6Raw, new[] { Environment.NewLine });
        private static string Day6Raw => @"fbqjswm
qmbjwfs
fmsbjwq
smjbqwf
hwsqmbfj

sxpoqbueg
fbhxqzjrtdkgwaepos
qbepgsxo
pbxvosegq
giqepcobsxl

gd
pfdy

yijwkdzvoub
cifujkyvbwz

htumjfskxapveoblncy
tkvfxpejomnbhcuslya
xukpmyenothacjfbsvl

dyt
hclpfxvykumo
bwjyi

ezfiytx
pitkrf
fpeki
gbuovijdfqaw

wyxabpekmlovhu
lueyowbmvkapxh
emhakvlyouwbxp
obyxlewkmaphvu
vmhaobxeklypwu

qerwhnkioygzcsulbjxa
wlegxsyupobaqzcnri

awroqhfs
abyfqops
ikqcgzatjuen

lnxdjmpvirbeus
gazhcwfy

jqo
qonj
oqjcs

qgahfybi
dbhjfwcgy
zgfhyqb

urtsfljxgc
teyorfwlxgu
uvrlzpkixgnmtq
tardhlxjuog
uxetgbrlw

apehszymrlwjqgu
mhqjgdzlswryuxa

vnamzidfsojth
ouvqmlhpbrdjfzawit

zus
muczs
xuzsr
puzsg

actgknebysj
cjbgesnkty
uemgdkcynst
stfqcgneyk

rgxsfmiplkobquvzedntwya
wyietkrnhzamxouvsbdqlfp
sevfloziqnmtjrubypkxwda

lsj
sjl

ihyvfqesulxorctjgmzpdank
hycmevxlsfdugproiqztknja
ujmdnqyltxvswzfhpkgoiecrab

mynlpojwqtk
hisrag

gaw
agw
agw
gaw
wag

pkoq
dtqbypcoj
loqpf
eprvmoq
rqepo

bfuheqvzsjignmctwl
jfszbqegvhmlcniuwt
txjsgivlzcmwauehbdnqf
tejwzcvlbnuqmgfish

qutrxvl
zytdmqrx
rxecqta

fayzme
vazey
yazj
aybhzsdc

csnjhrfyqbxiav
rfvaycxqihsbn
fixpvahcqsnrjy
nclzsixrfvoyeatkmwhq

quey
enxuq
qeup
utwqe

rbosi
tirdojubs
boris
borsi
iobsr

mdskbhvyiqertul
uqbltrykimehsv
ktvmyjuchreqblis
hequalkrsimybtv

rsitupnoy
fzwksemhcbq

vkrsfmljcbzdthi
tfdlkqjpmgh
mkqtfhlpxajd
thdkljmf

mrfpbwyx
rwfxmyb
yrxwbmf
fmwryxb

rmztba
uabrzmtpy

kajxyerviqthbzcomgnsfwp
wkhjetspdmblnyiqgzafcvxr
egyirpvajwxmnbzqkhosctf
whpcbruzkxeivftysgnjmqao

o
o
o
o

vmjwhzngqtaxl
ivhnfdcgtzqjwma
zagqmhnwvfcjtky
gjatqhwzyrnvm
wckanzhvmgqtj

azixnsjvh
hxvsaj
xvzhnajws
lgxvhasj
chqksxrevjuoaf

wlbocnkiyjdfmvgue
mychvijfbekulrgw
fvymucjewsghlbki

jczgonpt
jfzibgon

k
k
k
k

r
v

oeafxtjqhrdlgupwisc
lvhyjegkwrfpasxcto
cszalfyrtxbvwgjpeoh
axhzcepjgolstwfvr

hqfdymlisknuaejc
rptnamdkobqciujxh
nlgayihvumdkqcj
ickfhdauznmjq
niqzkcjaudmh

zavtjyul
uyaihcbjtzmnfvq
yjwdaerztp
tqoazjsxlymk
ybjaztql

gz
qxgal

sdhcagp
scahdpg
ahgdpsc
adsgcph
gdsfcaph

ysud
ydoxpqhesu
tbsjyudn
bsdvyul
dsyvcut

onizqprkeumy
teckol

fxlohzwgkebcn
rznhkfocgjvde
ktgefihnomzc
bsmypfchqxneoazgk

robwtniusy
quisghwtdv

mhtxubnl
yhmdtwcupezvxabl
kthbulmgrxs
bqhutximl
uxqhibtlm

nyifbxuq
ohmpfrntzdc

aityekusrc
yuecirak
yricukea

fbhntzkpalduvrjeqxg
najtimzflgcdqpkyrxb

byi
puln
ytdc
vafzwhsjkqxge

zngipme
inzpmjsx

sxrwd
yla
nf
uhjzpvbme

xpmhcy
yxhpcm
ychxpm
ychxpm
cpxhmy

wvmspxgrf
wxgsfivm

uwcfnb
caiyqxovdp
jstmchku
lctezs

hy
hy
yh
hy
hy

urepkmtblcfw
ejxuiacmvonpbr
pmzgbqruyech
wcpkuzbrmhes

jo
oj
jo
oj

gepdsrkwazxfyql
equrwsaxyl
ylwsxaqer
lrwyqesmax

ceist
iwhudaxgreyvfbz
kqeospit
ienjqm

roqikgmtubnapl
rtepiyvfsouj
iqrdlgtubpoc

rgtedxo
xegotdr

tkz
kzt
ktz
tzk

aimcqg
qagrebmic

ra
sa
a
a
a

djzixkqyt
lhreum
cgwel
lamr

dom
omd
mdo

virpctxulowjq
xrwlpjucqsiot

ljxzenhfvqburo
jqoenfbvhxyl
vcmfbyhwnoqjel
sikqfvlnebgtjho
lnejfqoxhyvpwba

ebqkrwfijg
jkrgbwf
ybwrfjgvk
wjkqegrbfv
hwjukgbflxr

mnqukrsvfctlpbewidz
coiuealptqmhwvdrskf
slyjekvhmrptwcudfqi

gdhqrenioakvfj
gedaivwzxqyfoskr
dckqormvbgjelhfai

cegixsmlduz
iegdslzcumx
zedksiugcmxla

aznelohvw
jovendlawh
uehwyvorminfa
avwenoh
hnwpaove

xvbtpinmaud
qxruionfedm
nxigmhud
uitaxznmd

dirpsgulvjwxkqzof
rmdpjuyivlwkozqfsx
wzfiskheluoqxjrpvd
qasjkzxilcdofvurpbw
wrqhudxkfvspizjlo

dhefy
ehfyqnsdlb
yhezdf
heyfd

hyla
hyal
lyha
avlyuh

q
p
ip
y
p

nasejwkfdgz
awegjndsfkz
sdwjfgezakn
neawsdzkfjg
gdnzwakjesf

vdsa
asdv
svad
savd
savd

dqyxjwvu
afxhvbgz

yvhxzrckdmebwoistlfpaqguj
qhsyupcixrwfobkjzlmvt
uyftrkhwlspnzixqbcomvj

zukomqjdtwaphyrcfb
qdyhjwuzcrmfk
yuhkjdcrgefmzqw
jwfqmgcxrkyheudz

m
gjkar
hni
hs

emc
ecm
cem

bfuxtzqyrwsldgjhep
ymlrtqpbosdewgaxju

uvphrftqsaekbzxj
vzhxajqfpuekrsbt
tqzpvjuskrabehfx
ypqrbafxksjzuevoth

tm
ap
a
a
o

zknhwxbclamjgvsefoy
dlrfvhkyjnsexzbmagcw
gxwklbjehofacnmyzsv
hvajsfnzkcxemlygwb

fmsjqhkxyw
jsfmhqywxk
wsqmjfyxhlk
bqhjcmfyskwx
mksxwqyhfj

buxi
i
wh
s
ab

ywjbtszuhniaopd
wyibtcejfznmdohqua

cjgstbahpzfrnqkeo
ecpboaqzgnkrjftsh
ztajpchkgnbvqsrofue

vtibnfojdaxekhgmy
myajhtdnbfoxvgik
jnavmlytwdfshbkxrigo
khiamfxngvdojtyb
kidbhfmagyjvtxon

lnupbwhodmei
imelnobphdwu
neipbomlduwh
lumneowihbxdp
hiublekowpdnm

lypirvqzcw
kziwqypxvr

yeadtgixzn
nydxeztga
qdfkoagyncxtze

otvm
ilvham
qrvbkxj
wveoz
fulicv

leazscfdotkuhxmr
eocdxshlaufrmtzk

mdtlwyin
ydnitwlm
ymtwlind
idmtnlyw

zuonrg
gwzxneor
urznbgol
qbrkzgnou
roqkngz

ywbpxicgstaufmozedqkrjv
xbvgnfltorzwceiqampkyshuj

chkmy
qsbamjn

emvlydfruaits
kerixnwlbu
zxwjbliepur
ouzeilr

ybiu
cyru
zpkv

pqcdevnlraiwtjmfxk
njtlacpbixdekv
dxlykvipagctnj
xkjltagcndivp
suvhkcaizpdoltnxj

cgqnapzvfwyimk
qpcvzgaywmfnik
zykcamvpniwqgf
kyfiavmgzpcqwn

t
t

xqhpuljcgbzyi
thyndcqw
ncqyhmvr
dhfaqmcy

s
sgz
opvswqtx
s

rikeqfvdla
jqfacvosgu
vfqae
vbdfqrwa

mfewqjdkcb
xnogrlmah
nvimla

zcfxogw
xgcpotfljw
geyfaomxc

uync
dny
yn
ydn

zvpuajx
pquz

q
y
y
w

phk
hmk
kdh

ljcumvrwdsfpzixhqgantoybk
lcgwubvzspqoramyetkxjdnhf
uqmsdhlptyfobanvgkrczxjw
uxqvyhbzkjangmtsldfprocw
avgmoswrxhdjypftczknuqbl

vyxclotkrzefghanjmipsu
tvzmrcywlsoqkebdai

gdrnybwsuxfc
yrbpmnfus
bvfcshmntuyr
onaisrfqkbyzu

slpetjhcvmaufd
tpfvdaumjechsl
ejcasvltdfpmuh
shtuaepcfjlmdv

bqwhndkeotmjcv
skcwtjeymbvqdohi

rebfqy
gqeybf
beqyf
yfbeq

kzoenrdtc
zdwtnx
nzdxgt

cdta
kjroqnldu
tuvc
hyegxbwfmzis

qpdfokyxsubanv
sfxkupnabvy
ukbypvxafsrn
srfpvxnbyauk

wxdkupoba
cdfxkpwobau
obkdwnxupa
qzulkwoxdhpba

vqzxurtjcbeild
qzbgklntdijvhcsxwye
jtdvxqzebclmio
plutvbjiqedzxc
utbzcjxovliqde

shvwemxcjlodknriy
xowueychnfmsrpkvj
ynewmskzjvhpqcxor
wcsqkhxzjmyvoern

tghcpi
igcthp
pctigh
higatcp

khnlfdogbtmqsc
rstoyencgilkb
ktzgljpboauncs
govcnjlwbqthsk
bnlkotqgcus

clfqxtajgw
wxaclufj
wfjxdaucvl
xwljfcia
jcyplrhsowxmbfaz

jwvuczdk
ujzwvdck
cdjzuvwk

wqrpskjbzxd
sqevgnkropcaxiu
xhsbfrmkqzp

g
g
l

lbtvkxeuiycrwsjpad
watikedxycljrupbv
cypkrxtlbvomawueidj
jbewavliyrdxctkup

r
jwur
r
r
r

fmdxyhr
yrdfhxkm
mhyrfxad
lrdhixmfty

rpanbukoyqmcew
wdku
ktluvgwi
wkuf
guhkjtlw

kbfcnapuvxdme
demhltfxpuinvc
fcnpehixdvm
nqzoxcdmpfyvejg

qscuwkvpl
uafwkqylspi
zchkwfvusa
shxnwyquk
romjtbsudkwe

bzorewil
oebzwli

ihzmnublpsga
gpaziqbvsxnmth
mnzispgaohb
zshingbamp
yimlhznrepgbas

slbzwpftqcvj
vfupdwrezscojyx

ukofntijmbryecd
cyejmbfnudorikt
dryfiukceojnatbm
enfdmjtyboickru

ukzfgsanmldiqej
zldmsqgnifjbke
oylgasqfkjnmedzpi
glfmqeijdzsknh
ijmesznldkgfq

fyxhmu
btyvfih

fcasuqmiborhtyw
cyusmhpwrfoqae

pvmj
qmpuvd
mbpvr

fu
fu

cmsharebt
tycsehablrm
ebhcrsmzao
ebasmxchr
seacrmhbn

phf
fph
fhp
pfh

x
x

cklhmiqbfrav
hfivmclbqakr
acvilfbqhmrk
vlfahbrickqm
xamcrbqifvkhld

ldykra
arkdly
lrdkay
aldryk
dkyrla

bf
f
f
f
f

sja
j
jn
hj

syr
r
w

ajitzbsk
ktiasbzj
bijhskazt
jbiamtskz
btkiazjs

ci
b
x
b

jgbzatyevmdwoirh
ayidemzjhrvb
muzbjqfishxenyrdlav
vmyjbredaihz

nsta
pvxsn

pwe
pwe
pew

skydwacovhbrq
cdbhorkvywaqs
avwybqkcdshro
rbakdocqywsphv
qowhgfcavbsrdyk

soewtgjpcdvla
gijtxwdlevpaysc
todevpzwglcjas
gacdfrwmpsuvebtlj
wgvlcdkejtpaons

kboigesmfr
ufjo
pohfjqn
qozf

jet
zrejt

ygb
yug
myg
gnysplqjod

kjqsrbofmeinawhlzgxtd
ehdtcmjrksfziqvlabwxo

nqdvlzregyfp
wvhlpnmdzegkyf
mldhexvnzpgsfy

m
m
r

yxkrzaov
urvzmxaigdk
sazvketrjncb

jhmgqebw
zalupkdf

myhwf
yhwfm
wmyhf

ujqmvybntwlfgrskz
vufrdgszeblymkntjq
vuonrfqbslxgjyzptk
yzkunbfrjtlqgsv
fjqyrgnluvbtzsk

yvxrmbogtfziqeclpjwdknauhs
ldwjkqzotvynuxahcpfmersgbi

bapjknqrem
qgmpnrh
hnrpmocq
doqurpmn

ramwtungpzjv
wzrvngmtjpua
zurgmatnjwvp
pgtzrmvujnaw
janzpvurmtgw

mencbuo
folkueabn
zqayub
pusrwjd
tkylhu

x
qsfmnyuow
eg
xbde
xr

jqiwyx
wix
iwx
xiw

d
jilwe
xgvf
b

qauwef
yvbcijs

pxykceoad
k
kznifl
k

rh
hrm
hdr

iertpcvhdyojnsfa
edchyptlnsjiaow
onbpaysiuchedjt

ulrjawfezdq
dytianoelkqxwmgfju
ufvawqjdhespcl

pagzxn
zangpx
xnpagz

xlksupgydimtb
dgpbsxtymluik
lgfubtvxcsdmypiwjz
yimltngspdbuox

phc
ihpc
phc
cph
cph

ybumkwiegvpsfrladzjh
sfajurxbncqevwkgdyptl

gr
rg
rg
gr
rg

hrkvgpintusxzcfbjdo
habgkptcrzdfxylvui
ngdctqkpuxrzvhifbo
kfuztmcrhdpbxoivg

zslmwoeh
lehzswp
zewlsh
zswelh

tqgwiukvmxbopradencjsylfzh
tnojksulryzdehqvawbcpgxmfi
iqotslzpjeyrgbxfhudwvackmn
rbvxpctodlegihunyfjwzqkams

cuzwomlixbfganhk
yglfvnwzbkimorux
xiqgnmkfobzwul
ifkbxolngwmduz
jztklouwfgibnmx

heobpftukwcrxyngj
gfhemvqxajotpz

maektfpjqbyhz
kiabmewjf
abkvocefmj
arkmjenfb

xyufbcmjtlvwgp
ouwcfryxvzsje
hxwcaqyfuojvn
fcqujheyvrxw

lqtbuxhfwnk
wynbhe
zhwnvb
rswdhcnib
bwhnr

wxcnqskthobyzumapgejl
npcjubmkhwyolgszaeq
opzhqjlyuegmwnsabkc
okehynrujmapqigswzcbl

lyjnuwtpgobavfh
oawgyuhvpntfjl
vgjydfopntlwahux

vfioljdqtsz
dqlvojfztwp
elofzvdjtuq
gqhzdfbotlvj

ebhnvgqjct
gkqulcjwze

ugncyzxqvjmlirf
xlomqekjyrdanwhfv

tqhupz
lwtjuai

uhvk
l
lg

qjy
pcyjq
jbqy

duoyfsnhlc
jtlpvohxsauzb

hkoqtgyvmjdwlnpicx
noxkdlhygpmvqjtcwi
ojqdthcywlgxenvimkp
hcxwygvdjpklmoiqnt
wxtjcpdylgnmkhviqo

jzuei
eib
ei
eiy
iez

pujfagxbze
faejixpg
mgtwqevaxsfjrhp
aexzycgfdkjpl

iunmadwyvlsxtpjck
ruihstgbkmqoxzfcdenw

qkvxdctszruljmpganbho
pumocnxkdlvrhtjbszaq
hurqpmotnlcsfdjvxzakb
bsrjuhxntkpmoqvaldzc

suktgmbnrqfahj
jqhsrkbfmntgu

ogaxbpiwvufktecdynlz
bqshpjmgr

dbikqj
kqbjdi
kibjdq
bdqijfkl
qjdbik

pa
otd
akn
jsrqmvwf

jr
mr

xdgrfvbncsjaltiqkyhm
qtswydkimlnzagvxch
equasoltvmyidngkpxch

maqpjnebszkftoc
rskduxejyvqg

k
k
k
k
xark

tiokl
hnzadijvbq
xi
lieo

xfjlskdabohcvzmtpur
zgvlqrjoapmbtufhc

urceayoxjsh
lnzvwqmpdbt

g
g
x
g
g

zuwgj
guzj
guzqhrj
zjgu

xsjotcbfzqlkewiv
ypxfhkjliuc
ljrmcxkif

ycgevt
wkxhe

a
a
a
a
ja

imwespvrudzaqojc
wvjiodspemqrzuca
mwvdzqosuciapjre
cpwejouzqadsirvm
eirmvjqzapcwsdou

yt
i
i

ovxmc
xmsczv
smvxc
xvmc

ynogzuevhipsbrwt
uezhvrpbontwiyg
swivytbuzegrhno
tbvyhoezurngiw
nuvygohteirbxzw

hvktyilwjpxdngouam
tayjndpghiorzvluxkm
aonsixtfpgmhlejkudyv

hdatbcv
zmyxugq

lmajoitgubwvpf
ibloytfwumjapvk
alfrwiutmhvjbpeon
mojdtpbaliuykwfv

wblkycgps
lkgpcyswb
wsybgplcvk
cublspdwgjyk
ygplbkcsw

pwyqvokde
vdreypwk
ypevdkwr

lykv
riz
sgjwtmoub

jobiqznpsugm
czjamsyuipnklqobg
bpnotjugsfzmqi
bgoqnsjipuzdm
gubnqozpijsm

qukzafenwyhblosmrgvx
zvlfurkwceqasohi
suzeolakhvfqrwpi

iycm
ciy
icy

hmxz
zxd
xzl
xmdz
xz

yftbrxvucjkniem
dqtl
tqog
tphazw

imkegrwdxybuav
kneiomxygdavrwb
rgoiamenwypdkxvb
wrqdahgfiemkyblvx
emxrkywigvbad

zk
mw
d
e

ihcwvxeotpzfrkqsl
syjiahxvnoebfcpgqkzmrud

foktjcszgwhr
fokqcndbyizrhaeswgl
vkrfsocpgwhuzm
rwhkgscxfzo

y
skt
fg

ejirwohkzfub
hujfbrkozn
oknucvzgfjhbr
jzlormuvhfkb
xfsouqjzrpbhk

scbejldiaz
jsblace
hbejsal
slabuje

osfej
hjsoek
oejszk

la
wl
al

icquzebwdkrhs
cbiukwresh
ruwhkseicb

ikcqygtvfsnaurelwd
ybukjdmlecvxpawzho

wfhyiscdpjvgktoz
dvhfkowiyzts
dtvysikzwoufh
vesyhiqtkdzfow
vtskzynhfiowd

xszyugwmdoflejaknqibt
fzoavqsumdwpgynkjltx

lctpvbshq
pslc
scwlp
cglpnws

xpyteraozhluwfcj
jueoaltzypcfhxrw
rwycztuahoxjpelf
fuhoprexjytazlcw
wyapzfeohxtrculj

xd
rsxv
xc
x
uxmle

uh
p
pw

u
u
u
u

qvhmxwtfrzcjolynesbkdip
qvnsibxmzrdowltpkhfeyjc

ezvopirtq
vitqzope

iewnmbouxctfadgh
tgsmjucxadby
daubxgctm

b
b
b

fhswi
limr
rhlp
fihp
uykdoc

wbfhklqaug
jlxvnqadzhksfw

tunfikcwpexs
gkwpmcsurtnieo
akpwxstecinuo
upskvwtnyjiqzech
wudbengklptsric

loedjctvbszkw
pgxrlihqa

gjwok
jgowk
owjgk
kwogj
gwojk

f
fyd

gajmfcikbnrylhpsx
mrcpingkjlbhfxysa
hacxpgrifkynljmbs
flajskgnbrhpixcmy
fincblhsgxrakypmj

xazukhfjyqtm
makzthqyf
qakymfzhlct
kaihzqydfgmtb
tzfjkqhyvma

dgzlpe
elqpzg
ezlpg
eplgz

s
r
r
a

cohzy
zlyv
dfwuptbg

ypjodgshuetcrlxfzv
tsrzlbgdpvqojueycfai
reopcljuysvtdgfmz

n
fp

tjdbzgfs
z
zreuvpqy
zpci

noekg
gonek
eaogkn
oknge

tkmxfod
domkft
kdtfmo
ktmdofy

anode
aoke
voea

ryhe
rhey
yerh
hyer

ntabgs
bg
bg

huktgwiosylrpdxjbcf
dfrixhluowksjbytp
sjhrolybpuwzxdikft
ysjhwokurbfptdlix

bifxwln
xh
fwmsou
hmyuqwc
apkrjvegtd

ezhytmakiwou
whmyptnuasodj
toruwaqmyxh
vgnyualodmthfw
whmuygato

qk
mq
huqz
lq

bejyhfndolxqt
axebjclthoqdniy
tnjbqyhwxdsel
lztqyfbvjkedhncx

eqyfglxicuzdphjkvnmsoat
equwiagnvpjcbyfxorhdzsm

msjyh
ymjh
yhmrj
uydjmhx

xqbldatriuhm
rnbczjkgyow
rteib

jkqnoawyvbreizsdp
zbsxirwpynkveoaqmjf
darzwpqijnbouekvsyh
kjipoehwbyqszvarn
ervysjwbpzanokiq

npbehmoiswz
opinhmwszdb
howmbpsnzi

rvpgdjaoc
opjdracvgh
cdvjgqaprno

liegxqpjzmvrfdykbsncahwo
gnfhykipdxzwcbvlqeajmors
dqcjlfonayphbvkzsgrweimx
oglnszmehxfriyjkdvawbpqc

pokiwqthmvfzadbjrucxglye
orzuptjqblnaedghvwciyx

tw
ocdgpm
aj
jhuti

pclrgmiefodu
bxvg
jzhngt
thgvsxnq

duosnjqakwleh
kzjendahmlworqsu
suwlbjqkedonah
qwsjuaheknidol
lpjfaonekwiudhsq

antqsypzmujbkihwclvg
rtqwhlzkasiyjubgmncv
qytmphkvbunijgzswacl
qumiyzsehadnckjtvwlbg

sbec
sb

puflvmxnwzcdqotirgejab
clwoqjmsgpurezfdivnxbta
qnfwizdgelvaoujspbmcxrt
lozmarwqjevbpgxtcifnud
adcqjwporbnvltfhgezuixm

zfayukrmjv
xkveunzar
kevozrcanu
zuaowvrk
itvazgkrnue

skocmigb
kgsimnbco
getuchifkqpbo
ogbcki
gvokbic

frmzlsjgenowiuvdqka
svliznoqgdufjerwkam
kiyoafjmvdsnwlurzqge
gwrdfniuavqejxmplzsok
mwzqvaiedolksnrfhjgu

kfluwecmzvnx
mefvkqcnuzxlwp
yvkeumnxlcfzw
kclfnzuvwemx

kmgerotqfv
kgmevqrotf
vmqtofkreg
terkfvgomq
rqvofketmg

akenjtzfbycvxgu
xhwnozegkubj

tveuglsjwpfmq
lphsowtduefg
saeuptowfdcgl

axqvchtd
xaqbkvct
taxiscvgnyq
zluqpxwavctjo
cvtafqx

phowmcdy
ocdmhpw
pdmhowc

ifakxsn
sixfkna
insxkfa
iknfxas
sfixkna

jtsoef
osfwt

flm
mf

xh
xh
xjh
xh

yvkxuiphbl
ivuxkhlpy
ukpxlhivy

hgbz
z
z
z

gvwfz
zvw

dvs
vnesudy

nmajxvozyhelpbt
avthblepmzjyonx
jzxevylaotbpnmh
ehxajptmlyndovbz

knayxrlzgoiwjvsdh
lyrhgwenxsvjkiaozd
vrwdstgoqkjzahxnlyi
yanojxkrsvwzldihg

ekcoubjlryfvdaqmztxnw
ethkxgdwvmjsconbifzpqra

egcibkxu
bigxuekc
uxeikcgb
gkbcuxei
begukxic

mvhcaezgbs
bmcegavh
ghevzuabcm
hsagcmbejvl
eabgrvmchyx

meglpzdkqrsohf
yzhedarogbmql
rzmioqdyhengl

tdosc
cstod
otdcs

szxwv
xhns

fsmvhdn
ldvsfh
hfskvd
sfdvh
chledfvs

gdmwvnyqihtspbfcexrou
bumficazjrpgxynwldoqvt

dyplaojbvhmtseiczkrn
zmihtdnpsbryoklcejav
zidcnhvmajteplkbsroy
hoyvemcnjrdbtalpzsik
lvbrejikdynxuozamhpsct

ouqbsjwxadlftyhi
ofvuzqtxyihldjeswab
aotxfjwduqimsyhlb
bdoalxwhfjtysqiu

ie
ec
se

mnflwaopgbcvhxt
boqymvanthlxwcfg
faowzgvxcthbml

jl
jl
jli
jl

kxdpqbcgvuimw
wmpgidkxujc
wmgyxrupickd
kpdgwiumfxc
mxwicgrdukp

jfsvrhqwpteckmuz
ltcqsdhjbauxikepwvr
jqtkwfhepcvrnus
hnqupekscvtrjwz

tfzxdcs
zcdkx

wiocksjvegyptdbnaml
inohseycvjpwdgtmak
jodxsiwmazkqvgcypnte
rigwopdtceymvasknj
nytbjmkcwpsgeofriaudv

vghoqamjewufp
qevtoxkmagfdsw
xaeqgmwvocf

cfkheaivnjqp
qdpnezv
loubwgsryxtm

pgsdcueklha
wthpgvjf
qzyxbonr

z
v

mzlonai
djcfgnrkatuxl
qnlaie
bnpal
vanle

qcszfvwlagrbniuo
bfrqzluigncswao
oacwngblqiusrzf
qrzbclnfswguoeai
noalwcsgfzirqbu

bk
gbks
ukb

opgkvynaqexmiublrsfwjthc
mbasfctuyerhqwvxgldnozk

cdlnpxkqsbvhgemr
gdheqkmlnvbpsrwx
fmdnsrvghkebqxltp
rgszqbkemldxpnhv

phociwjgq
inospahluxet

qup
aln

lk
l

s
s
s
s

pyucgnt
ynltgc
ycnugtd
ctqsngimyo
ycngt

vchjzu
ujczh
chzju
czhju
jzuchi

rdl
oljzkd
bdle
ldvb
drl

ypaxs
ycxps
ysxp
pxsy
slypx

dmeniwsrapqchtv
rbsizl
bxgrfusiyok

qdbpuxghfelwjtzsomyiva
oiqhdzluajvtswekxp
xjnlaihstvpqudzweo

tdzjxu
zjutdx
ztudxj
xdtjzu

xd
dx
dx
dx

notxgaqvpbyfje
raexdhikm
zalxdscewm

tlhk
clg
yo
gcnzot
frveaxij

riohxqt
hvdqts
vcqsdht

mi
fw
ch

mcfgtbsp
ekpgstc

hugfk
adn
st
itno
cod

btkzcna
czntbk
zkctbn
tbczkn

yaisrtpjuhngmox
psjoatrgynzduh

jxersuyobnqkathwpid
jsbeaixorpyqwhduktn
eidwbvyjpurnxkhotalsq
yorqhesaxiwjnudbktp
kunxwsytoijdqbaephr

gpozmvuctyaljws
yfxzogtjmua
efbyznatgjorimu
ojgruzmqytah

s
ezj
p
gdnmykaxo
irlp

fakoitvqlwxumjcypnrbh
xoikwhmjevcrfblqptnuy
jhpixuvltyeqbokwcfrn
nxorwfctihpyldbjsvkuq
twrmbujavfcnxhiqolkpy

gfcwqieompdtyluhz
gwhcoqtfelmzpyiu
tuyhinpflqcwomegz
owlckiyfpgzuqhtje

knpagzftyjxcs
ptxakjnygf
nsyxafjtgukop
pkgjnrztevfya
qytdmbpwkfgajn

yjuzgsvermfhotainbckd
ckbyoagrnmvfestihj
bgincyhfosvtkmejra
togvjersmynbfcihak

wicho
ihokc
icohw

buacxrg
xurabcg
uagbxrc
bxugcfar
uckxbgar

fdjnxbgzky
xngyajkzd
yjozgnxkd
njxgzkaody
zodyjngxk

pfuebk
ku
ku
uk

ysgf
j
sgy
qb
mhe

oygrdsel
lrysdke
dpyesiflrw
ydselr
pieyrsfjwld

zpewx
ewxpcz
wepzx

xyredbkszaicqolv
idqolxrbsyczea
iyrqdxcasezlbo

ilqd
qlid
idulyq

buwdolahxfrcnjsz
rfujabnwhx
ufrjpxnwahb

abulqncx
ocxauqn
cznuqxak

mhnyswie
omcbwyhefv

pbrxtumijaqgdkwzvceonls
mkhgzbdvxwcirnpeujoaqtls
npcxyftmjzgsraoilbqekvwu

dhiysqlbmjvoxf
ovxshjmfliqdy
zolsifhxvjyqmd
rnxdfvahmoyptjkieqgslu

ibvnlah
lavuibnhzp
bahilvn
bilnhva
hilbvna

voqfmayzbektjwui
iezmjtbovkwfu
vkwbeozfmtiju

jaxetsymlnr
eakjrmynslx
mnajeysgxrl
marlnxejygs
gmnjaiselxry

pyufthdvaqxngbk
nvhlbfjtwmdzsax

icwsjyfge
wyjfgeci

dut
tu
ugt
bhtu

g
g
fgtohm
g

ozagcvu
xqsfjgzouc
zoucgm
mzcugto

qujrhkixfslameon
ukdmpgeshrxnzj

excbvslqhad
zjotgsyenurp

jrqiwlcz
cerwlizh
wlpndrbci

gjstrhckqnw
rntqjskhcwg
thckgwjnrsq
qcrstwkhnjg
wcsknqgrtjh

wmcfgezspqdha
kgswzfdqbmcrnehp
hwdztacemgfspq
ywehgqcfsdmzp
yhcdgpzqsfmwex

okyxslua

gpioxhjkdbqlzsey
gkebjhyzxlqso
lbejqzxhyokgs
seoyjgqzlxhbrk
qblxvhejygskoz

zgl
gvlzn
gzl
ldgz

us
us
musql
us
us

uhv
hvu
vhu
hruv
huv

oaxt
ptdghjq

xgvmr
vzgxemrj
rvxglm
xcrmgvl

glb
lgb
wgble

kngvreujcafyblwxpqi
pqufgkwayxejlvnbci
xcekdwlpyjqbfgvahuin
ujxanebwlmrfpivqykgc
slaputxbcwfgyjoevnqizk

lyvfakznbuw
olfkrsbp
xojfmqlhbpk

hax
jp
nmf
eh
awi

q
nxmch
k
q
k

dch
dh
djgh

cmtpfzibwqkg
cgkwtiqzbpm

zksd
dzekascj
zhikpgru
kyoz

py
tpy
yp

hkbuqicdzretsxvmgoa
mdgfwnyvtlqpecrak

jc
cjv
jc
cj
jc

dtalrc
dlct
mdchlt
ctld
cadtlr

ostayzjxpilrcuebngvwdmkfqh
udgxyozfepsncwbhqvlikarjmt
bcaiurltfjqedgpsmzvkwyxhon
isawcgvmdyjhtbpnfoluxezrqk
ndrtewqcbmuovigpsyzxkfhjal

w
mz
z
p
m

ilmdn
dsilum

swaorjlgbevdmcftqy
whgxuakfpitvonqmz

odmuanyzbjekhrl
gwlzhamukeoby
huoyavkmblez

ctsauv
tubvcg
huczavt

gtljuexfiopmdhnczsaw
gjypnkrhsdxlumziea

zdrsfectygwjviob
qobcjzmrthpygdvewi
iatxzgldynjbvkwo

emknygaiptjlwozxc
cewyziltojnphkxga
xfkizjnaepytcsgwol

cxvdkfn
uxwtf

hd
d
d
d

uqzhkesytb
zsktbuhyieq
ybhqzsekjaut
hztybeuksq
kubyqehtsz

r
e
w

sgqnzlp
nqlfsg
uengqdcl
gyflsqtn
fmglnq

rokebxmfy
btemfy
byfkeagvt
bynfdezsh
ebfyir

aqpmvyefrdwongujs
jvmnwyuadefqrgsp
uvgaqrfydsjwnemp
lvcdbwuaesqzgmyjnpfr

rgcbejutw
gjebwr
gbjrwe

wnucbkymsxirfovhaezpltdq
fqmwrtynzohbxkspdviealcu
rdhseiqycpfztvlnmxboauwk
drualzqxiykobhecswptnmfv
sevolnphmryaxwdfqkuctbiz

kxesgvrpfatzomncu
poynusfktagrzmvxe
taszrmefonwukpvgx
nzvkyepsfxramuhtog

x
z

mqf
fqm
fmq

plqknez
znrucvosqe
ewzqnak
jaqzednl

mvfsz
v
su
getnakyh
x

jdvrwyizulgthfacpb
zkhmsyaxwoebcdpngtrfj

zhd
dhz

vqidfwokxbhzatslcn
wcbzgfutloskarvxnhe

rhds
rtp
nlrfsh

stqk
owtksmq
kstzq
sqtk

kjunerphs
hnjskeu
sehdjkoun
snheujkt
uknjesh

syelrcmhftj
mbvtofei
bpeftmvd
zfxnpteom
efoztm

ih
hi
hi

ypiaz
piay
yapiov
ypeia
apiy

lvriun
vinul
vlin
vzldni

rwkvyshp
uwasr

bxpgfq
pyqgrbf
bpfhqg
qpfcbxg
pbgfq

zvtcugahijyenw
lvngtcduirwjakzm

fpqbrzjimtdlwnvchy
bjpzmwytcvhildqnfr
dzqmcflinbprjtvwyh
whytcnjilqfvzdbprm

iwfpka
ipfwa
imfwap

hjuyc
mlwjv

ulpjhvsnbztfiqe
nlhbqteupzio
inzepqhbtlu
hmbztrcliquenpd

fjxgrhpeozl
rholfeu
rlqochfe
eflroqh
ofrhle

rowfxmt
f
fp
ijf

zqbokvdhw
zvohebqgw
howvprmjztlnqbu
vgqbzoewha

dtwf
wvtfd
fwtd
wtfd
ftdw

tdmzifqp
tzpiqdmf
zftpdqim

lgv
qhl
ljyaxzwocmbrk
nls
npuld

zuol
vo
oxnykdec
oulmz

uoevmcpgyixrflwtasjhqzn
elpcxtgmvjiynfowzuashqr

v
l
c
l

fuz
ufz
zuf
fzu

zgfhiodeybckqxp
tiquwkmeaxcp
gzieqkpjhxnc

dlpcyjzfhekuiqgom
khpgieujcfmoylqdrz
uqeckojzfimyldhrgp
ciyqmlapgfjduehzko
fijhqmkeucgzwdploy

odqthnlcgsu
csprkbo
cebzso
cswbero

fsph
psh
psh
phsiju

tgrwxaqibelzhm
jynqdvfo
cjuqopnk

iheu
uih

rjyqhauivsoz
srvcnahokuq

i
kon

tgvukpcxnory
fxuhsmeativp

kvyha
vykah
hkvya
hyvak

lpahrbqe
hlrpqbwe

ndtoxjfsp
tvjdeoxlp
phxasrotjdn

vcpzksneyxfo
uevyhslzcpxgt

wpxvmnghz
vmxphwz
hvwxzkmp

usvdwyomecfip
suweomifpvcdy
csiuwmvdpfeyo
mosdfwuyeivcp
ycupmidwofsve

hlqbanmtjy
tdrvxcajgnfpoke
jtiunkpsroa";

        public static string[] Day7() => RawConverter(Day7Raw, new[] { Environment.NewLine });
        private static string Day7Raw => @"posh teal bags contain 2 faded coral bags, 3 striped crimson bags, 1 faded red bag.
mirrored chartreuse bags contain 3 clear beige bags, 3 shiny silver bags, 3 bright green bags.
dotted red bags contain 4 light chartreuse bags.
faded chartreuse bags contain 1 striped black bag, 1 dim coral bag, 5 mirrored maroon bags.
bright teal bags contain 3 light black bags, 4 striped fuchsia bags, 1 dark chartreuse bag.
dull orange bags contain 5 striped green bags, 3 plaid plum bags, 3 pale gray bags.
dotted tomato bags contain 5 plaid blue bags, 2 dull maroon bags, 1 mirrored maroon bag, 3 posh brown bags.
drab tan bags contain 1 striped chartreuse bag, 5 dull lavender bags.
mirrored indigo bags contain 3 mirrored fuchsia bags, 2 striped green bags.
bright white bags contain 2 dark green bags, 4 bright yellow bags.
dotted cyan bags contain 1 posh orange bag, 2 faded white bags.
vibrant orange bags contain 1 faded silver bag.
plaid lime bags contain 4 shiny olive bags, 5 dim olive bags, 1 dotted gray bag, 2 clear black bags.
pale green bags contain 2 plaid silver bags, 5 dark blue bags, 1 muted blue bag, 3 posh white bags.
dotted brown bags contain 3 dark bronze bags, 5 posh fuchsia bags, 3 plaid cyan bags.
muted yellow bags contain 2 vibrant fuchsia bags, 4 striped brown bags, 3 muted tan bags, 1 shiny plum bag.
light crimson bags contain 3 bright lavender bags, 1 shiny olive bag.
striped black bags contain 2 drab aqua bags, 1 clear black bag, 5 mirrored teal bags, 3 dark chartreuse bags.
faded olive bags contain 2 drab aqua bags.
clear black bags contain no other bags.
dark coral bags contain 4 drab magenta bags.
striped brown bags contain 1 bright lavender bag, 1 wavy lime bag, 2 dark chartreuse bags, 2 dim aqua bags.
dull blue bags contain 5 plaid purple bags, 1 drab chartreuse bag.
dark indigo bags contain 5 vibrant white bags, 3 bright lavender bags, 1 bright tan bag, 4 drab aqua bags.
shiny tomato bags contain 1 dark chartreuse bag.
plaid maroon bags contain 5 striped black bags, 5 drab green bags.
plaid brown bags contain 5 plaid indigo bags, 5 shiny gray bags.
dark yellow bags contain 2 vibrant cyan bags.
bright maroon bags contain 4 shiny beige bags.
muted maroon bags contain 3 striped bronze bags, 4 clear gold bags, 1 light red bag.
plaid purple bags contain 1 faded magenta bag, 5 dotted turquoise bags.
wavy chartreuse bags contain 2 clear purple bags, 2 drab green bags, 3 wavy maroon bags.
posh indigo bags contain 3 striped crimson bags, 5 mirrored maroon bags, 1 mirrored crimson bag, 2 drab orange bags.
drab black bags contain 1 drab plum bag.
striped gray bags contain 5 shiny teal bags, 2 vibrant magenta bags.
light yellow bags contain 4 clear black bags, 2 dim olive bags, 5 wavy lavender bags, 2 pale chartreuse bags.
faded tomato bags contain 3 dark aqua bags, 3 pale turquoise bags, 4 pale purple bags, 3 posh plum bags.
posh crimson bags contain 1 drab green bag, 3 dim aqua bags.
muted tomato bags contain 1 dim orange bag.
bright indigo bags contain 1 posh brown bag.
dotted silver bags contain 4 vibrant teal bags, 3 wavy violet bags, 4 dark black bags, 3 dotted orange bags.
dark fuchsia bags contain 3 vibrant salmon bags, 3 dotted gray bags, 2 dull chartreuse bags.
dull indigo bags contain 5 dark gold bags, 1 light crimson bag, 2 light bronze bags, 5 vibrant chartreuse bags.
light gold bags contain 1 plaid indigo bag, 1 mirrored crimson bag, 1 dull indigo bag.
dark cyan bags contain 2 dull brown bags, 5 bright fuchsia bags, 3 striped purple bags.
posh chartreuse bags contain 1 light gray bag, 5 wavy tomato bags.
bright gold bags contain 1 clear teal bag, 1 dim purple bag, 5 striped bronze bags.
striped magenta bags contain 5 vibrant chartreuse bags, 3 wavy olive bags, 5 mirrored orange bags.
mirrored gold bags contain 2 striped fuchsia bags, 5 wavy yellow bags, 5 dull lime bags.
dark chartreuse bags contain no other bags.
dim bronze bags contain 3 dim coral bags, 1 light plum bag, 1 posh orange bag.
dim coral bags contain 3 shiny teal bags, 5 plaid bronze bags, 1 vibrant magenta bag, 5 faded yellow bags.
bright lavender bags contain 4 bright indigo bags, 4 faded yellow bags, 5 posh black bags.
posh cyan bags contain 1 dotted violet bag, 1 shiny violet bag, 2 dull chartreuse bags, 2 wavy turquoise bags.
wavy lavender bags contain 2 dim fuchsia bags, 1 dotted red bag, 5 clear maroon bags, 1 dull lime bag.
vibrant salmon bags contain 4 posh indigo bags, 2 faded tomato bags.
clear gray bags contain 5 dim olive bags, 1 striped turquoise bag, 4 striped tan bags, 4 plaid lime bags.
bright cyan bags contain 1 pale turquoise bag, 4 vibrant white bags, 4 muted gray bags, 2 clear orange bags.
posh purple bags contain 1 striped tan bag, 1 dim aqua bag, 4 light bronze bags, 1 bright chartreuse bag.
dim yellow bags contain 1 posh lavender bag.
dim blue bags contain 4 light indigo bags, 5 shiny fuchsia bags, 5 drab fuchsia bags, 5 dark purple bags.
wavy cyan bags contain 3 clear beige bags, 4 striped blue bags, 2 faded coral bags.
mirrored orange bags contain 5 dark bronze bags, 3 striped blue bags, 2 posh orange bags.
muted orange bags contain 5 dotted violet bags, 5 bright violet bags, 2 vibrant salmon bags.
vibrant coral bags contain 5 bright cyan bags, 5 shiny indigo bags, 2 bright bronze bags.
bright gray bags contain 1 clear red bag, 5 dull orange bags, 4 bright cyan bags.
muted bronze bags contain 4 dim lavender bags.
shiny blue bags contain 2 dim chartreuse bags, 3 muted beige bags, 5 mirrored plum bags.
posh bronze bags contain 3 dull purple bags, 4 wavy magenta bags.
faded magenta bags contain 5 clear tomato bags, 5 dull plum bags, 4 light red bags.
posh tan bags contain 3 clear olive bags, 4 clear lavender bags.
muted teal bags contain 1 striped magenta bag.
dull brown bags contain 2 drab black bags, 3 striped bronze bags.
shiny white bags contain 3 faded blue bags, 3 dotted salmon bags, 2 drab black bags.
wavy red bags contain 4 vibrant magenta bags, 3 muted green bags, 4 mirrored teal bags.
dim silver bags contain 3 striped purple bags, 5 drab violet bags, 2 striped bronze bags, 3 wavy green bags.
dull magenta bags contain 1 dim crimson bag, 1 light aqua bag.
dull plum bags contain 5 dim indigo bags, 2 dotted red bags.
mirrored lime bags contain 3 bright tan bags, 3 bright orange bags.
muted green bags contain 3 faded yellow bags, 2 drab maroon bags, 1 dark chartreuse bag, 2 mirrored teal bags.
clear crimson bags contain 4 posh fuchsia bags, 2 dull aqua bags, 3 faded tan bags.
drab aqua bags contain no other bags.
dull chartreuse bags contain 4 dotted gray bags, 2 dim red bags, 3 dull yellow bags.
posh aqua bags contain 5 striped orange bags.
dark blue bags contain 2 dark gold bags, 2 faded yellow bags.
posh red bags contain 2 mirrored brown bags, 4 shiny orange bags, 4 striped lavender bags, 5 light turquoise bags.
dim lime bags contain 1 muted turquoise bag, 2 posh gold bags, 2 dull violet bags, 3 dotted lavender bags.
faded yellow bags contain no other bags.
dark red bags contain 2 posh beige bags, 3 shiny tomato bags, 3 light salmon bags.
dull purple bags contain 3 bright red bags.
dark violet bags contain 4 clear salmon bags, 2 dark gold bags, 1 dotted cyan bag, 3 dim purple bags.
muted indigo bags contain 5 striped bronze bags, 4 posh olive bags, 5 striped purple bags.
plaid crimson bags contain 1 bright violet bag, 3 bright red bags, 5 clear orange bags, 2 dark purple bags.
muted silver bags contain 1 clear tomato bag.
dull black bags contain 4 striped gold bags.
faded red bags contain 1 posh indigo bag, 2 striped crimson bags, 3 muted indigo bags.
muted lime bags contain 5 plaid lavender bags, 4 dim fuchsia bags.
mirrored crimson bags contain 4 light bronze bags, 1 wavy red bag, 4 drab violet bags, 4 faded white bags.
posh gray bags contain 3 dim olive bags.
posh violet bags contain 4 mirrored white bags, 4 dim indigo bags.
plaid black bags contain 5 bright purple bags.
vibrant indigo bags contain 3 mirrored blue bags, 4 dim teal bags, 2 dim beige bags, 1 light black bag.
mirrored beige bags contain 3 plaid tomato bags, 5 faded black bags, 3 vibrant aqua bags, 4 striped coral bags.
pale turquoise bags contain 2 faded beige bags.
striped tomato bags contain 5 dull indigo bags, 2 dull plum bags.
muted black bags contain 3 faded plum bags, 5 vibrant tan bags.
dark crimson bags contain 2 muted black bags, 2 faded gray bags.
dark turquoise bags contain 3 posh olive bags, 1 striped crimson bag.
faded crimson bags contain 1 posh tomato bag, 2 dotted tomato bags, 1 shiny lime bag.
mirrored yellow bags contain 2 wavy gold bags.
dull silver bags contain 5 plaid blue bags, 4 faded green bags.
pale salmon bags contain 1 clear fuchsia bag, 3 muted white bags, 4 pale violet bags, 2 vibrant yellow bags.
pale plum bags contain 3 faded green bags.
shiny turquoise bags contain 4 shiny maroon bags.
plaid magenta bags contain 5 posh salmon bags, 4 muted tan bags, 3 light silver bags.
mirrored black bags contain 1 pale plum bag, 5 wavy gold bags, 1 mirrored magenta bag, 4 clear lime bags.
mirrored magenta bags contain 4 clear beige bags, 2 plaid indigo bags, 4 faded coral bags, 2 clear tomato bags.
striped lime bags contain 5 muted white bags, 4 faded tan bags, 1 dull plum bag.
pale coral bags contain 2 posh coral bags, 2 mirrored turquoise bags, 4 clear yellow bags, 4 wavy teal bags.
dotted gray bags contain 2 drab aqua bags, 1 faded coral bag, 3 clear black bags.
faded tan bags contain 1 shiny salmon bag, 5 drab plum bags, 2 dotted lavender bags, 3 shiny yellow bags.
dull aqua bags contain 2 faded black bags, 5 bright indigo bags.
dotted violet bags contain 2 posh green bags, 3 plaid lime bags.
faded aqua bags contain 3 clear gold bags, 3 striped bronze bags.
vibrant yellow bags contain 4 pale magenta bags, 2 pale black bags.
posh silver bags contain 3 shiny black bags, 2 dull purple bags, 1 light lime bag, 5 muted silver bags.
vibrant purple bags contain 5 pale olive bags, 3 muted bronze bags.
drab orange bags contain 4 dark aqua bags, 3 posh black bags, 4 shiny beige bags.
clear green bags contain 1 dark lime bag, 2 bright orange bags, 2 mirrored maroon bags, 3 dark bronze bags.
dark tomato bags contain 2 drab yellow bags.
clear blue bags contain 3 pale bronze bags, 3 drab aqua bags, 3 striped tan bags, 1 shiny tan bag.
muted red bags contain 3 dark olive bags, 3 faded teal bags.
wavy olive bags contain 5 faded chartreuse bags, 2 striped black bags.
pale red bags contain 4 bright orange bags, 5 drab orange bags, 2 striped brown bags, 2 striped bronze bags.
dim brown bags contain 1 posh purple bag.
dotted lavender bags contain 2 bright chartreuse bags, 2 pale gray bags.
clear aqua bags contain 1 vibrant plum bag, 5 dark plum bags.
wavy fuchsia bags contain 1 pale purple bag.
dim tomato bags contain 2 faded red bags, 3 clear teal bags, 4 striped chartreuse bags, 4 shiny green bags.
striped maroon bags contain 4 posh coral bags.
bright yellow bags contain 4 dark tomato bags, 3 pale gold bags, 4 dark gold bags, 5 shiny tomato bags.
pale maroon bags contain 3 posh cyan bags.
clear lime bags contain 4 faded coral bags.
light violet bags contain 4 vibrant magenta bags, 3 bright yellow bags, 3 dull chartreuse bags.
dotted maroon bags contain 5 mirrored salmon bags, 1 striped tomato bag, 5 dim coral bags.
pale violet bags contain 1 dotted tan bag, 2 wavy white bags.
clear salmon bags contain no other bags.
dotted tan bags contain 3 posh beige bags, 4 bright chartreuse bags, 5 posh fuchsia bags, 2 pale gray bags.
vibrant tan bags contain 4 dark plum bags, 3 clear teal bags, 2 faded yellow bags, 3 light chartreuse bags.
pale lime bags contain 4 muted crimson bags.
muted blue bags contain 2 light salmon bags, 1 bright aqua bag.
plaid silver bags contain 5 striped magenta bags, 2 dull chartreuse bags.
clear gold bags contain 5 shiny gray bags, 2 vibrant white bags.
dim salmon bags contain 3 striped olive bags, 1 faded teal bag, 3 posh gold bags.
muted gold bags contain 5 shiny lavender bags, 5 bright orange bags, 3 dark lime bags, 2 dim blue bags.
dotted orange bags contain 4 muted lavender bags.
plaid yellow bags contain 2 posh green bags, 5 faded white bags, 5 plaid blue bags.
posh yellow bags contain 2 shiny lime bags, 2 mirrored cyan bags.
wavy lime bags contain 3 vibrant plum bags.
clear teal bags contain 3 mirrored blue bags, 3 posh maroon bags, 2 muted cyan bags, 2 drab aqua bags.
faded maroon bags contain 1 dull magenta bag, 3 dull green bags, 3 muted coral bags, 5 pale beige bags.
drab salmon bags contain 5 faded tomato bags, 3 clear green bags.
pale orange bags contain 4 clear orange bags, 4 wavy fuchsia bags, 5 clear cyan bags, 5 dark red bags.
clear indigo bags contain 1 shiny gold bag, 2 light aqua bags, 2 bright orange bags.
faded gold bags contain 1 posh maroon bag, 3 faded indigo bags, 5 muted purple bags, 3 wavy tomato bags.
drab cyan bags contain 1 wavy white bag, 3 dotted turquoise bags.
striped blue bags contain 3 shiny beige bags.
vibrant black bags contain 3 bright blue bags.
striped green bags contain 5 shiny orange bags, 5 muted tomato bags, 1 clear teal bag.
posh maroon bags contain 1 striped purple bag, 3 striped gray bags, 1 dark chartreuse bag, 5 vibrant magenta bags.
dark beige bags contain 3 drab fuchsia bags, 2 mirrored cyan bags, 1 striped crimson bag.
wavy crimson bags contain 1 mirrored aqua bag.
striped gold bags contain 1 vibrant tomato bag, 5 faded aqua bags, 5 plaid salmon bags, 3 mirrored blue bags.
dim plum bags contain 1 posh orange bag, 4 vibrant chartreuse bags.
mirrored cyan bags contain 2 vibrant tomato bags, 4 clear black bags, 4 striped gold bags.
plaid lavender bags contain 4 shiny lime bags, 4 pale gold bags, 3 posh teal bags, 1 dull lavender bag.
wavy magenta bags contain 1 dim red bag.
wavy bronze bags contain 4 shiny bronze bags, 1 drab turquoise bag, 5 muted tan bags, 2 dotted aqua bags.
drab coral bags contain 3 dim lime bags.
dull teal bags contain 1 vibrant aqua bag, 4 wavy lavender bags, 1 dark purple bag, 4 dark violet bags.
faded beige bags contain 5 plaid indigo bags, 5 clear beige bags, 5 dull violet bags.
mirrored gray bags contain 3 light bronze bags.
dark green bags contain 1 dark violet bag, 1 posh black bag, 4 posh fuchsia bags, 1 shiny olive bag.
posh coral bags contain 1 striped purple bag.
muted salmon bags contain 1 bright orange bag.
mirrored teal bags contain no other bags.
dotted turquoise bags contain 5 dark tomato bags, 1 plaid plum bag, 2 wavy gold bags.
wavy tan bags contain 3 dim cyan bags, 2 dim maroon bags.
light tomato bags contain 5 muted cyan bags, 2 dotted green bags, 4 dark aqua bags.
mirrored green bags contain 5 light tomato bags, 3 dim magenta bags, 4 drab maroon bags.
bright black bags contain 2 mirrored violet bags, 3 dull brown bags, 5 clear gray bags, 3 dull chartreuse bags.
bright silver bags contain 1 dotted brown bag, 4 vibrant yellow bags.
pale black bags contain 5 drab magenta bags, 5 vibrant magenta bags.
wavy indigo bags contain 2 dotted green bags, 1 shiny orange bag, 1 dark lime bag, 1 mirrored blue bag.
shiny fuchsia bags contain 1 muted lavender bag, 5 posh beige bags, 3 clear salmon bags, 3 posh brown bags.
muted white bags contain 4 posh orange bags, 4 clear orange bags.
shiny lavender bags contain 3 wavy olive bags, 3 dull crimson bags.
clear violet bags contain 5 shiny plum bags.
striped purple bags contain 2 drab maroon bags, 2 vibrant magenta bags, 3 shiny teal bags.
clear tomato bags contain 3 posh brown bags.
wavy purple bags contain 4 striped indigo bags, 5 striped crimson bags.
dark teal bags contain 2 dim coral bags, 5 dim fuchsia bags.
drab blue bags contain 5 dim indigo bags.
faded gray bags contain 5 dull brown bags, 5 mirrored brown bags, 3 shiny magenta bags, 5 dotted violet bags.
faded violet bags contain 3 wavy purple bags, 2 light maroon bags.
pale brown bags contain 5 clear red bags, 2 plaid chartreuse bags.
faded white bags contain 2 drab maroon bags, 2 shiny tomato bags.
posh brown bags contain no other bags.
dotted olive bags contain 3 pale teal bags, 1 bright purple bag.
mirrored fuchsia bags contain 1 dull maroon bag, 5 dull green bags.
dark orange bags contain 5 striped lavender bags, 1 posh black bag, 1 dark purple bag.
pale fuchsia bags contain 5 plaid fuchsia bags, 1 dull lime bag, 4 pale bronze bags, 2 bright cyan bags.
light brown bags contain 5 vibrant bronze bags.
faded bronze bags contain 4 dim silver bags.
vibrant chartreuse bags contain 5 shiny gray bags, 5 muted lavender bags, 3 posh fuchsia bags.
dim teal bags contain 4 clear red bags, 2 faded silver bags, 1 muted blue bag, 5 wavy yellow bags.
dotted chartreuse bags contain 4 striped fuchsia bags, 3 bright lavender bags, 3 vibrant blue bags, 4 mirrored maroon bags.
dark purple bags contain 2 posh black bags.
mirrored olive bags contain 3 dotted brown bags.
shiny yellow bags contain 4 mirrored maroon bags, 3 dark plum bags, 5 muted green bags, 2 clear aqua bags.
drab turquoise bags contain 3 dim coral bags, 3 dark chartreuse bags.
striped orange bags contain 4 striped lime bags, 1 dim tan bag, 3 dull yellow bags, 2 vibrant cyan bags.
dull turquoise bags contain 3 clear purple bags.
muted fuchsia bags contain 2 wavy tomato bags, 5 dark maroon bags, 3 muted tomato bags, 4 vibrant plum bags.
faded coral bags contain no other bags.
bright red bags contain 1 dull crimson bag, 5 shiny teal bags, 4 shiny gold bags.
bright purple bags contain 4 plaid indigo bags, 5 vibrant maroon bags, 2 dim red bags.
light plum bags contain 3 drab aqua bags, 5 shiny tomato bags, 4 drab violet bags.
faded orange bags contain 2 shiny teal bags, 5 striped gray bags, 2 dull lavender bags, 4 bright green bags.
drab white bags contain 1 bright orange bag, 5 drab lime bags, 5 drab plum bags.
posh lime bags contain 3 faded chartreuse bags.
vibrant bronze bags contain 3 dim green bags, 1 clear gold bag, 4 striped bronze bags, 4 pale chartreuse bags.
dark olive bags contain 5 dim purple bags, 5 mirrored maroon bags.
striped plum bags contain 1 posh brown bag, 2 muted cyan bags, 3 faded yellow bags, 2 wavy plum bags.
plaid tan bags contain 2 mirrored lavender bags, 2 striped silver bags.
pale chartreuse bags contain 5 clear beige bags, 5 clear maroon bags, 4 wavy red bags, 5 dotted tan bags.
vibrant teal bags contain 3 bright violet bags.
vibrant silver bags contain 1 shiny teal bag, 2 pale purple bags, 5 dark lime bags.
wavy orange bags contain 5 bright bronze bags, 4 vibrant aqua bags, 3 pale indigo bags, 3 muted beige bags.
plaid tomato bags contain 3 faded teal bags, 1 dull green bag.
muted purple bags contain 1 muted lavender bag, 5 light black bags.
light red bags contain 3 posh green bags, 2 striped purple bags, 1 pale purple bag.
shiny magenta bags contain 4 muted silver bags, 3 drab turquoise bags, 2 pale turquoise bags.
light tan bags contain 5 bright green bags.
clear fuchsia bags contain 5 faded coral bags, 2 drab plum bags, 2 clear beige bags, 1 pale teal bag.
vibrant aqua bags contain 3 dim red bags.
posh tomato bags contain 5 wavy magenta bags.
drab plum bags contain 3 clear salmon bags, 5 mirrored teal bags, 4 striped aqua bags.
pale lavender bags contain 4 clear black bags, 4 wavy green bags.
drab beige bags contain 3 pale teal bags, 5 mirrored aqua bags, 4 posh beige bags.
shiny aqua bags contain 3 striped black bags, 4 striped blue bags, 4 light salmon bags, 5 striped crimson bags.
dull white bags contain 2 faded brown bags, 3 drab maroon bags, 5 striped olive bags, 1 bright fuchsia bag.
vibrant gold bags contain 5 dotted aqua bags.
dim turquoise bags contain 2 mirrored turquoise bags, 4 dark tomato bags, 4 clear lime bags.
drab silver bags contain 3 drab plum bags.
plaid plum bags contain 3 shiny gold bags, 1 wavy red bag, 1 plaid bronze bag, 5 vibrant magenta bags.
wavy gray bags contain 2 dim plum bags, 4 light red bags, 3 wavy orange bags, 5 muted indigo bags.
mirrored plum bags contain 4 dotted violet bags, 1 dim maroon bag.
muted crimson bags contain 4 mirrored teal bags, 4 faded yellow bags, 5 striped aqua bags.
clear plum bags contain 1 dark indigo bag, 3 shiny gold bags, 2 dim gray bags.
dull gray bags contain 5 striped bronze bags, 5 plaid magenta bags, 3 muted orange bags.
plaid violet bags contain 3 dotted yellow bags, 1 dotted aqua bag, 5 clear orange bags.
light beige bags contain 4 dim tomato bags, 1 pale yellow bag, 3 faded beige bags, 3 dim yellow bags.
plaid olive bags contain 5 shiny tan bags.
faded fuchsia bags contain 4 wavy maroon bags.
bright crimson bags contain 5 bright orange bags.
drab chartreuse bags contain 4 drab red bags.
dotted plum bags contain 5 striped blue bags, 5 light gold bags, 4 vibrant teal bags.
muted plum bags contain 5 faded white bags, 5 striped brown bags, 1 posh brown bag, 5 drab maroon bags.
bright turquoise bags contain 2 dull indigo bags, 2 mirrored tan bags, 5 clear tomato bags.
drab violet bags contain 3 clear black bags, 2 mirrored teal bags, 5 faded yellow bags, 4 vibrant magenta bags.
dotted blue bags contain 3 posh black bags.
light silver bags contain 5 bright tan bags, 1 dull silver bag, 5 posh magenta bags, 5 pale chartreuse bags.
drab indigo bags contain 1 dark purple bag, 1 pale magenta bag.
pale teal bags contain 5 striped black bags, 1 faded cyan bag.
shiny coral bags contain 1 mirrored lavender bag, 5 mirrored bronze bags, 1 bright violet bag.
shiny maroon bags contain 3 mirrored teal bags, 4 light bronze bags, 5 plaid yellow bags.
dim indigo bags contain 4 clear salmon bags, 1 pale gray bag, 5 posh purple bags.
dotted purple bags contain 5 shiny tan bags, 4 posh indigo bags, 2 light maroon bags, 4 plaid plum bags.
pale indigo bags contain 2 dark orange bags, 3 bright chartreuse bags, 5 pale purple bags.
striped salmon bags contain 3 drab red bags, 1 light silver bag.
dim tan bags contain 5 muted silver bags, 5 dull tomato bags, 2 dull violet bags.
striped cyan bags contain 3 striped green bags, 4 muted cyan bags, 5 wavy beige bags.
posh gold bags contain 3 dotted aqua bags.
drab magenta bags contain 1 dim olive bag.
dull maroon bags contain 2 dotted gray bags.
drab lavender bags contain 2 dark tomato bags.
drab gray bags contain 5 faded plum bags, 2 faded turquoise bags, 3 shiny purple bags.
drab bronze bags contain 3 shiny indigo bags, 2 dull silver bags, 1 pale indigo bag.
dark gold bags contain 1 striped bronze bag, 3 shiny gold bags, 4 striped purple bags, 2 wavy green bags.
mirrored bronze bags contain 3 clear maroon bags, 2 striped plum bags, 1 vibrant plum bag, 5 mirrored aqua bags.
clear purple bags contain 2 dim maroon bags.
bright blue bags contain 1 vibrant aqua bag.
striped tan bags contain 3 clear beige bags, 5 bright chartreuse bags, 5 shiny beige bags.
plaid blue bags contain 4 wavy red bags, 3 clear salmon bags, 2 striped black bags, 2 drab aqua bags.
striped coral bags contain 2 shiny aqua bags, 5 light aqua bags.
pale yellow bags contain 3 clear aqua bags, 4 shiny indigo bags, 2 dim purple bags.
wavy black bags contain 5 light gray bags, 5 dim green bags, 4 muted cyan bags.
shiny beige bags contain 5 faded coral bags, 1 muted cyan bag, 2 dark aqua bags, 4 posh black bags.
mirrored red bags contain 3 striped blue bags, 4 bright yellow bags.
plaid chartreuse bags contain 5 dotted coral bags.
dark white bags contain 3 wavy white bags, 4 bright violet bags, 5 drab bronze bags.
drab lime bags contain 4 striped silver bags, 5 dim black bags, 1 posh teal bag.
clear magenta bags contain 3 dark tomato bags, 5 drab silver bags, 2 shiny indigo bags, 3 mirrored silver bags.
plaid white bags contain 5 dotted green bags, 2 light silver bags, 3 plaid lavender bags, 1 posh purple bag.
shiny indigo bags contain 2 drab orange bags.
faded green bags contain 3 muted cyan bags, 5 posh orange bags, 3 plaid plum bags.
striped bronze bags contain 2 light plum bags, 3 shiny teal bags, 4 posh black bags.
pale olive bags contain 5 striped gray bags, 3 striped lime bags.
dim orange bags contain 4 mirrored maroon bags, 2 mirrored teal bags, 4 dim green bags, 2 muted green bags.
pale cyan bags contain 1 light tomato bag, 2 dotted tan bags.
muted chartreuse bags contain 2 dim coral bags, 3 posh indigo bags.
dull tan bags contain 1 clear teal bag, 2 dark blue bags, 1 bright magenta bag.
bright olive bags contain 3 mirrored lavender bags, 4 plaid bronze bags.
dark maroon bags contain 1 clear blue bag, 4 dotted gray bags.
plaid coral bags contain 4 muted salmon bags, 3 light teal bags, 4 pale black bags.
pale beige bags contain 5 pale lavender bags, 1 shiny lime bag, 3 shiny yellow bags, 5 striped purple bags.
vibrant brown bags contain 2 drab yellow bags.
striped silver bags contain 3 vibrant aqua bags, 1 faded silver bag.
drab gold bags contain 1 bright salmon bag.
vibrant red bags contain 1 bright red bag.
striped chartreuse bags contain 2 faded chartreuse bags, 2 striped tan bags.
dotted yellow bags contain 3 drab aqua bags, 3 dark gold bags, 3 shiny orange bags.
dotted gold bags contain 2 posh fuchsia bags, 3 faded teal bags, 1 pale black bag, 2 clear indigo bags.
dark bronze bags contain 2 pale tomato bags, 5 posh fuchsia bags, 5 muted green bags.
drab brown bags contain 4 dotted magenta bags.
dull bronze bags contain 1 posh white bag, 2 muted teal bags, 5 vibrant tan bags.
bright brown bags contain 3 bright bronze bags, 2 shiny tan bags, 3 dull green bags.
dotted green bags contain 4 dim green bags.
vibrant turquoise bags contain 1 mirrored magenta bag, 2 dark bronze bags.
dim olive bags contain 3 mirrored blue bags, 5 drab maroon bags, 1 clear lime bag.
posh plum bags contain 5 pale indigo bags.
plaid bronze bags contain 1 plaid blue bag.
shiny brown bags contain 3 shiny salmon bags, 1 striped tan bag, 4 clear aqua bags.
clear olive bags contain 4 bright aqua bags, 1 clear maroon bag, 4 mirrored maroon bags.
shiny black bags contain 3 pale violet bags.
dotted lime bags contain 5 posh purple bags, 3 dotted fuchsia bags.
clear lavender bags contain 4 striped fuchsia bags, 3 pale yellow bags.
muted magenta bags contain 3 dim beige bags, 2 wavy plum bags.
muted turquoise bags contain 1 faded cyan bag, 3 bright tan bags, 3 striped brown bags.
wavy gold bags contain 5 striped tan bags, 5 muted salmon bags, 5 dark gold bags, 3 muted cyan bags.
dull violet bags contain 1 faded white bag, 1 striped black bag, 2 vibrant maroon bags, 5 faded yellow bags.
clear beige bags contain 1 shiny tomato bag, 5 posh brown bags, 1 faded cyan bag, 3 dotted gray bags.
muted olive bags contain 1 dotted chartreuse bag, 3 pale chartreuse bags.
posh blue bags contain 3 light red bags, 1 bright lavender bag, 4 dim coral bags, 2 clear lime bags.
striped olive bags contain 3 shiny gold bags.
mirrored tan bags contain 3 muted tomato bags.
shiny plum bags contain 2 dark olive bags, 3 wavy green bags, 2 shiny lavender bags.
plaid teal bags contain 3 posh purple bags, 1 muted violet bag, 2 dark tan bags, 1 wavy gold bag.
striped white bags contain 1 striped turquoise bag, 3 shiny yellow bags.
vibrant beige bags contain 1 clear olive bag, 4 wavy lime bags.
vibrant crimson bags contain 4 muted salmon bags, 5 light bronze bags.
muted aqua bags contain 4 plaid gold bags, 1 clear olive bag, 1 striped silver bag, 1 pale purple bag.
dotted indigo bags contain 1 light gray bag, 3 dark olive bags, 1 faded beige bag.
wavy aqua bags contain 3 muted fuchsia bags, 1 dull coral bag, 2 dark tan bags, 1 clear plum bag.
dull coral bags contain 1 bright gold bag, 5 dark salmon bags, 3 mirrored fuchsia bags, 3 bright crimson bags.
vibrant plum bags contain 1 drab violet bag, 3 shiny beige bags.
mirrored white bags contain 3 drab bronze bags, 3 shiny aqua bags.
dotted fuchsia bags contain 5 vibrant cyan bags, 4 mirrored teal bags, 1 drab white bag, 5 wavy black bags.
bright chartreuse bags contain 2 shiny gold bags, 5 dim green bags.
dim gold bags contain 5 muted purple bags.
posh olive bags contain 2 faded yellow bags, 5 dotted gray bags.
drab purple bags contain 5 vibrant beige bags, 4 striped indigo bags, 3 pale fuchsia bags.
drab red bags contain 1 faded blue bag, 5 dull indigo bags, 4 posh purple bags, 4 plaid bronze bags.
shiny gray bags contain 1 drab violet bag, 1 dotted yellow bag.
shiny violet bags contain 4 clear salmon bags, 5 shiny cyan bags, 2 shiny tomato bags.
plaid red bags contain 5 dull olive bags, 3 pale teal bags, 2 clear bronze bags, 1 light bronze bag.
clear coral bags contain 1 faded bronze bag, 5 dull red bags.
shiny purple bags contain 4 clear blue bags, 3 pale red bags, 5 dull tomato bags, 4 shiny orange bags.
dotted black bags contain 4 muted tan bags, 2 dim tan bags, 2 muted cyan bags, 2 dull black bags.
pale blue bags contain 3 wavy gray bags, 2 drab violet bags, 2 dull chartreuse bags, 5 plaid yellow bags.
mirrored lavender bags contain 1 wavy green bag, 3 striped brown bags.
plaid turquoise bags contain 4 clear gray bags, 1 muted green bag, 3 dull tan bags, 4 shiny indigo bags.
bright tan bags contain 4 shiny olive bags, 1 clear salmon bag, 4 bright indigo bags, 2 drab maroon bags.
dark lime bags contain 4 bright chartreuse bags, 3 posh maroon bags, 1 shiny tan bag, 5 pale bronze bags.
clear turquoise bags contain 3 bright orange bags, 1 faded yellow bag, 5 posh purple bags, 1 vibrant coral bag.
plaid beige bags contain 4 light blue bags, 5 bright bronze bags.
pale gold bags contain 1 pale indigo bag.
light maroon bags contain 3 faded cyan bags, 5 shiny lavender bags, 3 drab yellow bags.
posh white bags contain 2 mirrored lavender bags, 2 posh teal bags, 3 dull teal bags, 1 plaid salmon bag.
shiny tan bags contain 2 bright indigo bags, 3 plaid lime bags, 3 light chartreuse bags.
wavy violet bags contain 2 drab orange bags.
dotted bronze bags contain 2 mirrored aqua bags, 3 dull fuchsia bags.
dull lime bags contain 2 bright lavender bags.
shiny salmon bags contain 5 posh olive bags, 3 pale teal bags.
light lime bags contain 1 light plum bag.
mirrored silver bags contain 1 clear purple bag.
dark magenta bags contain 1 dotted yellow bag.
dotted white bags contain 2 vibrant aqua bags, 5 pale green bags, 1 dark fuchsia bag.
posh beige bags contain 4 drab maroon bags, 3 muted cyan bags.
faded blue bags contain 5 muted tomato bags, 5 clear black bags, 4 muted gray bags.
dim fuchsia bags contain 5 dark gold bags.
vibrant lavender bags contain 4 shiny purple bags.
pale bronze bags contain 3 wavy red bags, 4 shiny tan bags.
plaid orange bags contain 3 vibrant indigo bags.
bright coral bags contain 3 faded olive bags, 4 striped coral bags, 5 plaid violet bags, 3 bright lavender bags.
striped teal bags contain 1 striped magenta bag, 5 plaid white bags.
plaid gray bags contain 4 dotted gray bags, 3 clear beige bags.
faded salmon bags contain 1 dotted turquoise bag.
striped violet bags contain 3 dim cyan bags, 5 drab plum bags, 5 pale gray bags.
dotted magenta bags contain 3 plaid bronze bags.
dotted salmon bags contain 4 wavy tomato bags, 2 vibrant silver bags, 5 dim aqua bags.
dark aqua bags contain 3 posh olive bags, 4 clear salmon bags, 2 striped purple bags, 4 faded yellow bags.
vibrant cyan bags contain 4 light red bags.
pale aqua bags contain 5 clear brown bags, 1 muted cyan bag, 1 pale maroon bag.
clear brown bags contain 5 vibrant white bags, 2 clear blue bags.
dim black bags contain 3 muted salmon bags, 2 plaid bronze bags, 4 shiny cyan bags, 4 posh green bags.
pale crimson bags contain 5 pale lime bags, 1 mirrored tomato bag, 2 dull green bags, 2 mirrored teal bags.
shiny teal bags contain 5 dark chartreuse bags, 4 faded yellow bags, 3 faded coral bags.
faded brown bags contain 4 plaid plum bags, 5 mirrored orange bags, 4 shiny aqua bags.
pale silver bags contain 1 bright turquoise bag, 2 mirrored yellow bags, 1 faded red bag.
light black bags contain 3 shiny indigo bags.
bright orange bags contain 1 faded coral bag.
drab fuchsia bags contain 3 wavy lavender bags, 3 plaid yellow bags, 2 clear olive bags, 4 clear red bags.
bright lime bags contain 2 dull magenta bags.
pale magenta bags contain 1 faded white bag, 2 faded salmon bags.
light cyan bags contain 1 wavy yellow bag, 3 bright crimson bags, 3 striped violet bags.
shiny silver bags contain 3 shiny olive bags, 1 dark plum bag, 2 muted cyan bags.
shiny red bags contain 3 posh turquoise bags, 5 pale gold bags.
muted coral bags contain 1 shiny aqua bag, 5 dim green bags, 2 muted purple bags, 4 pale turquoise bags.
dark black bags contain 3 shiny gray bags, 2 mirrored aqua bags, 3 vibrant magenta bags.
dull yellow bags contain 5 clear teal bags.
shiny lime bags contain 5 posh magenta bags, 3 light salmon bags.
muted tan bags contain 4 bright chartreuse bags.
bright magenta bags contain 4 dotted violet bags, 2 light gold bags, 5 dim indigo bags, 4 dark olive bags.
faded lime bags contain 3 mirrored gold bags, 5 wavy tomato bags, 5 muted lavender bags.
wavy coral bags contain 3 posh maroon bags, 1 striped black bag.
dull red bags contain 4 plaid yellow bags, 5 drab lime bags, 5 plaid plum bags.
wavy blue bags contain 4 bright brown bags, 1 bright magenta bag, 5 pale indigo bags, 1 muted tomato bag.
dull salmon bags contain 2 mirrored orange bags, 3 shiny plum bags.
muted brown bags contain 5 dull beige bags, 3 vibrant aqua bags, 3 clear lavender bags.
faded lavender bags contain 1 vibrant orange bag, 3 faded magenta bags.
vibrant maroon bags contain 3 muted crimson bags, 5 striped purple bags, 5 pale tomato bags.
faded black bags contain 2 dark purple bags.
dim gray bags contain 4 dotted coral bags, 4 muted orange bags.
striped yellow bags contain 1 dark salmon bag, 1 pale silver bag, 1 wavy brown bag, 1 light gold bag.
dim violet bags contain 5 posh magenta bags, 1 pale aqua bag, 1 pale maroon bag, 5 dim lavender bags.
plaid indigo bags contain 1 shiny silver bag, 3 pale gray bags, 4 dull maroon bags, 5 faded coral bags.
light purple bags contain 1 faded violet bag, 4 pale orange bags, 1 drab yellow bag.
faded indigo bags contain 5 faded white bags, 2 dotted lavender bags, 4 dark gold bags, 1 plaid plum bag.
vibrant tomato bags contain 4 light plum bags.
light coral bags contain 4 posh fuchsia bags.
dotted coral bags contain 3 vibrant magenta bags, 5 bright beige bags.
drab olive bags contain 2 wavy salmon bags, 2 pale aqua bags, 2 dark indigo bags, 2 drab green bags.
dull green bags contain 5 dull crimson bags.
muted gray bags contain 5 bright chartreuse bags, 4 clear fuchsia bags, 2 light red bags, 3 shiny gold bags.
clear red bags contain 4 pale teal bags, 2 shiny gold bags, 1 mirrored tomato bag, 4 faded yellow bags.
vibrant violet bags contain 3 light gray bags, 2 posh green bags, 3 shiny salmon bags.
posh salmon bags contain 4 muted blue bags, 3 posh purple bags, 4 dim silver bags, 5 faded white bags.
wavy white bags contain 3 wavy fuchsia bags, 1 drab black bag, 5 vibrant aqua bags, 2 wavy magenta bags.
light orange bags contain 2 light black bags, 1 wavy maroon bag.
shiny bronze bags contain 1 drab crimson bag, 1 clear purple bag, 4 dotted cyan bags, 5 mirrored yellow bags.
dull tomato bags contain 5 dark gray bags.
wavy salmon bags contain 4 wavy orange bags, 5 dull silver bags, 4 wavy maroon bags, 2 posh blue bags.
shiny cyan bags contain 5 vibrant plum bags, 1 plaid plum bag.
wavy turquoise bags contain 2 bright gold bags.
shiny crimson bags contain 2 faded indigo bags, 2 muted lavender bags.
wavy brown bags contain 2 clear indigo bags.
bright aqua bags contain 2 wavy plum bags, 2 shiny beige bags, 5 clear black bags, 2 light black bags.
light bronze bags contain 3 vibrant maroon bags.
vibrant fuchsia bags contain 1 dotted cyan bag.
dull crimson bags contain 2 plaid lime bags, 2 plaid bronze bags, 3 shiny orange bags.
mirrored tomato bags contain 3 clear maroon bags, 4 striped crimson bags, 3 drab plum bags, 5 plaid plum bags.
dark silver bags contain 5 pale cyan bags, 4 drab magenta bags.
posh lavender bags contain 5 faded olive bags.
bright plum bags contain 5 posh indigo bags.
faded teal bags contain 1 vibrant maroon bag, 1 wavy maroon bag, 2 dark violet bags, 2 pale yellow bags.
mirrored coral bags contain 1 muted magenta bag, 4 clear turquoise bags, 5 muted purple bags, 2 pale black bags.
vibrant lime bags contain 2 pale lavender bags, 5 clear purple bags.
dark tan bags contain 2 bright beige bags, 5 drab aqua bags.
muted lavender bags contain 3 posh olive bags, 2 faded cyan bags.
dull fuchsia bags contain 3 vibrant maroon bags.
dim magenta bags contain 4 faded cyan bags, 3 dim indigo bags, 1 mirrored teal bag, 5 vibrant teal bags.
posh orange bags contain 1 wavy green bag.
clear white bags contain 2 faded purple bags, 4 dotted yellow bags.
light olive bags contain 3 faded plum bags, 3 wavy chartreuse bags.
light fuchsia bags contain 3 clear orange bags.
striped turquoise bags contain 4 faded cyan bags, 4 bright green bags, 5 mirrored magenta bags.
light teal bags contain 1 clear gold bag, 2 dull olive bags, 2 clear teal bags.
wavy teal bags contain 1 light gold bag, 5 light chartreuse bags, 2 dim purple bags.
striped beige bags contain 2 mirrored cyan bags, 2 plaid aqua bags, 3 dull lavender bags, 1 dull chartreuse bag.
striped aqua bags contain no other bags.
shiny green bags contain 5 posh tomato bags, 1 faded olive bag, 5 pale maroon bags.
posh magenta bags contain 2 dull green bags, 3 wavy maroon bags, 4 faded silver bags.
faded silver bags contain 5 dark lime bags, 2 striped brown bags.
dim maroon bags contain 1 light crimson bag, 5 posh black bags, 5 striped bronze bags.
dim chartreuse bags contain 3 pale plum bags, 2 clear fuchsia bags, 3 bright beige bags.
drab crimson bags contain 4 drab orange bags, 2 dark blue bags, 1 shiny gray bag, 1 pale gray bag.
dim beige bags contain 4 dark orange bags, 1 shiny salmon bag, 5 bright indigo bags, 1 shiny indigo bag.
light blue bags contain 2 vibrant white bags, 1 pale turquoise bag, 3 drab maroon bags, 4 mirrored cyan bags.
dim aqua bags contain 3 bright chartreuse bags, 2 clear black bags, 4 dotted gray bags, 3 plaid bronze bags.
striped fuchsia bags contain 2 shiny teal bags, 4 striped aqua bags, 4 dull lavender bags, 2 dull crimson bags.
wavy yellow bags contain 5 pale gray bags, 2 faded red bags, 3 vibrant silver bags.
bright fuchsia bags contain 1 faded teal bag, 5 shiny lavender bags, 2 muted cyan bags.
mirrored violet bags contain 4 plaid olive bags, 2 dotted magenta bags, 4 striped aqua bags, 5 wavy lavender bags.
wavy maroon bags contain 2 mirrored maroon bags, 3 drab violet bags, 2 dark plum bags, 2 faded cyan bags.
dim green bags contain 3 clear lime bags.
muted beige bags contain 4 posh coral bags, 1 mirrored teal bag, 5 shiny cyan bags, 2 light plum bags.
posh turquoise bags contain 1 dull fuchsia bag.
clear orange bags contain 2 faded chartreuse bags, 3 dark blue bags, 5 plaid yellow bags.
light green bags contain 5 mirrored chartreuse bags, 4 pale bronze bags.
clear bronze bags contain 5 vibrant coral bags, 2 bright beige bags, 4 dark lime bags.
clear silver bags contain 1 bright gray bag, 5 dotted white bags, 2 dotted lavender bags, 1 dim violet bag.
drab green bags contain 1 drab violet bag.
mirrored salmon bags contain 1 dim beige bag.
mirrored maroon bags contain 2 posh black bags, 4 striped black bags, 2 dotted gray bags, 4 striped gray bags.
mirrored aqua bags contain 4 clear black bags.
pale purple bags contain 5 dim green bags, 3 striped tan bags, 5 wavy olive bags, 4 muted cyan bags.
dotted teal bags contain 1 dotted orange bag, 2 dotted chartreuse bags.
vibrant olive bags contain 2 posh olive bags.
dotted aqua bags contain 5 drab orange bags.
clear yellow bags contain 1 clear orange bag, 3 dim beige bags, 3 bright indigo bags, 1 drab yellow bag.
vibrant gray bags contain 3 mirrored plum bags.
dull beige bags contain 3 dull indigo bags, 2 dotted lavender bags, 2 shiny orange bags.
shiny chartreuse bags contain 2 light brown bags, 1 faded tomato bag, 1 drab black bag.
light chartreuse bags contain 2 wavy red bags, 4 muted green bags, 1 drab aqua bag, 4 mirrored maroon bags.
bright violet bags contain 4 dotted yellow bags, 2 shiny aqua bags, 2 drab aqua bags, 1 bright red bag.
dull gold bags contain 2 muted maroon bags, 1 wavy maroon bag.
dotted beige bags contain 4 plaid magenta bags.
wavy silver bags contain 5 pale beige bags, 3 posh orange bags, 1 clear turquoise bag, 3 bright lavender bags.
plaid aqua bags contain 1 dull lime bag, 5 plaid crimson bags.
drab tomato bags contain 4 wavy plum bags.
muted cyan bags contain 5 faded cyan bags, 4 posh olive bags, 5 faded yellow bags, 4 dark chartreuse bags.
dull olive bags contain 1 dark black bag, 2 clear gold bags, 4 dark orange bags.
bright salmon bags contain 5 dark chartreuse bags, 5 posh black bags.
wavy beige bags contain 4 dim green bags.
posh fuchsia bags contain 4 drab plum bags.
striped red bags contain 5 posh turquoise bags, 2 posh indigo bags, 5 dim silver bags.
dim lavender bags contain 5 vibrant chartreuse bags.
plaid green bags contain 4 striped fuchsia bags.
dull lavender bags contain 5 clear lime bags, 5 wavy green bags, 2 dark blue bags, 1 striped gray bag.
dark brown bags contain 4 light silver bags, 4 pale violet bags, 3 light cyan bags, 1 pale cyan bag.
wavy green bags contain 3 mirrored teal bags, 2 muted green bags.
drab teal bags contain 4 shiny teal bags, 3 striped aqua bags, 5 dim coral bags.
shiny orange bags contain 4 drab aqua bags, 4 pale teal bags, 3 dull maroon bags.
vibrant blue bags contain 2 vibrant tomato bags, 1 plaid cyan bag, 3 pale red bags.
mirrored purple bags contain 2 striped tan bags, 1 pale olive bag.
faded purple bags contain 2 plaid lavender bags.
light aqua bags contain 3 vibrant chartreuse bags.
vibrant magenta bags contain 3 clear salmon bags, 4 posh brown bags, 4 striped black bags.
plaid salmon bags contain 1 striped gray bag, 5 dark plum bags.
dim white bags contain 3 faded fuchsia bags, 2 clear yellow bags.
light magenta bags contain 1 vibrant turquoise bag.
clear chartreuse bags contain 1 posh olive bag, 1 drab blue bag.
clear tan bags contain 2 dark blue bags, 4 light gold bags, 5 muted indigo bags.
light turquoise bags contain 4 drab beige bags, 4 shiny bronze bags, 3 dull olive bags, 3 striped indigo bags.
pale white bags contain 5 dotted white bags, 3 faded gold bags, 5 striped turquoise bags.
dark gray bags contain 3 clear teal bags, 4 posh green bags, 2 striped brown bags, 3 light tomato bags.
clear maroon bags contain 5 drab maroon bags.
vibrant white bags contain 1 muted green bag, 5 dark aqua bags, 3 clear black bags, 4 drab teal bags.
striped indigo bags contain 1 bright turquoise bag, 5 shiny orange bags, 1 clear fuchsia bag, 1 light chartreuse bag.
dull cyan bags contain 2 light salmon bags, 5 striped magenta bags, 2 wavy lavender bags, 3 faded fuchsia bags.
wavy plum bags contain 3 muted crimson bags, 2 dim green bags.
pale tan bags contain 3 mirrored turquoise bags, 5 wavy salmon bags.
vibrant green bags contain 5 plaid chartreuse bags, 2 muted teal bags.
bright bronze bags contain 4 clear indigo bags, 1 mirrored bronze bag, 1 mirrored magenta bag, 5 posh beige bags.
faded plum bags contain 2 dotted tan bags.
mirrored blue bags contain 2 clear lime bags, 5 faded coral bags, 1 drab aqua bag.
plaid gold bags contain 2 muted tomato bags, 1 shiny blue bag, 1 dim gray bag, 1 dotted salmon bag.
posh black bags contain 3 faded cyan bags, 5 posh brown bags, 1 striped black bag.
light salmon bags contain 1 clear lime bag, 4 posh black bags.
muted violet bags contain 4 wavy cyan bags.
faded cyan bags contain 4 faded coral bags, 3 faded yellow bags.
faded turquoise bags contain 3 wavy magenta bags, 3 plaid bronze bags, 1 dotted chartreuse bag.
plaid cyan bags contain 1 shiny tan bag, 1 faded coral bag, 1 vibrant plum bag, 2 bright lavender bags.
mirrored brown bags contain 1 faded chartreuse bag, 2 striped plum bags.
light lavender bags contain 1 dull teal bag, 3 dark fuchsia bags.
striped crimson bags contain 1 light salmon bag, 2 drab black bags, 3 vibrant white bags, 5 dull maroon bags.
dotted crimson bags contain 1 posh orange bag, 4 muted green bags, 2 mirrored indigo bags.
clear cyan bags contain 3 light yellow bags.
light indigo bags contain 5 plaid cyan bags, 2 mirrored fuchsia bags.
light white bags contain 2 light chartreuse bags.
drab yellow bags contain 1 mirrored blue bag.
dim cyan bags contain 2 posh salmon bags, 5 bright chartreuse bags, 3 dark chartreuse bags.
pale gray bags contain 5 dim orange bags, 2 dark plum bags, 1 vibrant plum bag, 3 striped tan bags.
bright tomato bags contain 3 posh indigo bags, 1 dotted aqua bag, 5 muted olive bags.
shiny olive bags contain 2 drab aqua bags.
mirrored turquoise bags contain 3 shiny violet bags, 3 drab crimson bags, 3 dotted tomato bags, 5 bright violet bags.
light gray bags contain 1 vibrant white bag, 2 muted indigo bags, 3 drab teal bags.
bright green bags contain 4 bright indigo bags.
striped lavender bags contain 2 striped aqua bags, 5 light crimson bags, 4 drab maroon bags.
posh green bags contain 2 muted turquoise bags, 4 dark blue bags, 4 light chartreuse bags, 1 pale purple bag.
plaid fuchsia bags contain 3 shiny yellow bags, 2 shiny maroon bags, 1 clear aqua bag.
dim purple bags contain 4 light crimson bags, 2 dotted yellow bags, 2 mirrored maroon bags.
dark salmon bags contain 2 faded teal bags, 4 drab white bags, 3 posh bronze bags.
drab maroon bags contain no other bags.
dark lavender bags contain 4 muted brown bags, 5 dark orange bags, 1 plaid aqua bag, 2 muted cyan bags.
pale tomato bags contain 5 drab maroon bags, 2 posh orange bags, 4 pale bronze bags.
shiny gold bags contain 2 light chartreuse bags, 2 drab black bags, 1 bright orange bag, 1 shiny teal bag.
bright beige bags contain 5 dim teal bags, 3 posh indigo bags.
dim crimson bags contain 4 wavy lime bags, 4 dim orange bags, 1 faded green bag.
dim red bags contain 4 drab plum bags, 4 shiny gold bags.
wavy tomato bags contain 4 plaid bronze bags, 1 striped black bag.
dark plum bags contain 5 shiny olive bags, 1 drab violet bag, 2 striped black bags, 1 faded coral bag.";




        /// <summary>
        /// Method that takes the raw input of <see cref="Environment.NewLine"/> separated values and 
        /// converts it into an <see cref="IEnumerable{T}"/> list.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> containing the list of rules.</returns>
        private static string[] RawConverter(string rawInput, string[] separators)
        {
            return rawInput.Split( separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
