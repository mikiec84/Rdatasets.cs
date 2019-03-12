// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Macroeconomic Series for the United States
    /// </summary>

    public class MoneyUS
    {
        public readonly int κ;
        public readonly double m;
        public readonly double infl;
        public readonly double cpr;
        public readonly double y;
        public readonly double tbr;

        public MoneyUS(int κ, double m, double infl, double cpr, double y, double tbr)
        {
            this.κ = κ;
            this.m = m;
            this.infl = infl;
            this.cpr = cpr;
            this.y = y;
            this.tbr = tbr;
        }

        public static IEnumerable<MoneyUS> Data
        {
            get
            {
                yield return new MoneyUS(1, 1.95137866929827, 6.35459784919523, 7.41505469297157, 2.036667, 1.083667);
                yield return new MoneyUS(2, 0.905918988334342, 6.35366235776394, 7.41360856112157, 1.633333, 0.814333);
                yield return new MoneyUS(3, 0.359655940662229, 6.3626228007244, 7.42517908677635, 1.363333, 0.869667);
                yield return new MoneyUS(4, 3.85844546179968, 6.36380349660839, 7.43738302971072, 1.31, 1.036333);
                yield return new MoneyUS(5, 3.09707311625527, 6.3676166660348, 7.46307614263468, 1.613333, 1.256333);
                yield return new MoneyUS(6, 4.69575828239535, 6.36151062804635, 7.4722733169449, 1.966667, 1.514333);
                yield return new MoneyUS(7, 3.76945015869659, 6.35657456853841, 7.48335689568704, 2.326667, 1.861333);
                yield return new MoneyUS(8, 2.59972018523058, 6.3523052458293, 7.49214729970504, 2.833333, 2.349333);
                yield return new MoneyUS(9, 3.84699570494664, 6.34674672921902, 7.48829351515943, 3, 2.379333);
                yield return new MoneyUS(10, 2.66790927253702, 6.34189831847188, 7.49470826313568, 3.263333, 2.596667);
                yield return new MoneyUS(11, 3.59683290280994, 6.33333902418697, 7.49676341980094, 3.35, 2.596667);
                yield return new MoneyUS(12, 2.67376166988402, 6.33111078836289, 7.51021159425758, 3.63, 3.063667);
                yield return new MoneyUS(13, 5.48413776594021, 6.31966532536304, 7.51556241237507, 3.63, 3.171667);
                yield return new MoneyUS(14, 1.87418049844474, 6.31531277490524, 7.51469076272302, 3.683333, 3.157);
                yield return new MoneyUS(15, 2.92599053598685, 6.30796042705723, 7.52358935643941, 3.953333, 3.382333);
                yield return new MoneyUS(16, 0.156360863582172, 6.30278186979235, 7.51234443256029, 3.993333, 3.343333);
                yield return new MoneyUS(17, 2.27971063391053, 6.29557994735918, 7.49002676319615, 2.816667, 1.838);
                yield return new MoneyUS(18, 0.603713460315269, 6.30535595079393, 7.49798340553424, 1.716667, 1.017667);
                yield return new MoneyUS(19, 3.74846975405276, 6.30649543992378, 7.51800986145252, 2.13, 1.710667);
                yield return new MoneyUS(20, 2.74020896906126, 6.31243857928272, 7.53950566467676, 3.213333, 2.787667);
                yield return new MoneyUS(21, 4.30312396935353, 6.30800261931561, 7.55218479274465, 3.303333, 2.800333);
                yield return new MoneyUS(22, 3.58351515260083, 6.30761939615693, 7.5691537612275, 3.603333, 3.019333);
                yield return new MoneyUS(23, 1.5468158055663, 6.31084290870177, 7.56568970378634, 4.193333, 3.533);
                yield return new MoneyUS(24, 0.997237996634581, 6.29959754257271, 7.57142215421957, 4.76, 4.299333);
                yield return new MoneyUS(25, 3.50103228702903, 6.28798985641816, 7.58928524020189, 4.686667, 3.943);
                yield return new MoneyUS(26, 0.196590147890774, 6.28535168970527, 7.58665139377222, 4.073333, 3.092333);
                yield return new MoneyUS(27, 1.84974402567288, 6.28999655821745, 7.58766523276006, 3.373333, 2.390333);
                yield return new MoneyUS(28, -1.33462232623671, 6.29285985089066, 7.58126081928679, 3.27, 2.360667);
                yield return new MoneyUS(29, 0.0422488947664945, 6.29771233113738, 7.58953812946303, 3.013333, 2.376667);
                yield return new MoneyUS(30, 2.55607398596425, 6.29859661682942, 7.60389796852188, 2.86, 2.324667);
                yield return new MoneyUS(31, 2.27618110892127, 6.2987343633198, 7.6183493731458, 2.896667, 2.324667);
                yield return new MoneyUS(32, 1.4664583708587, 6.30409292286457, 7.63843906307081, 3.056667, 2.475);
                yield return new MoneyUS(33, 3.70147001604444, 6.30126865918745, 7.65150051230517, 3.243333, 2.739);
                yield return new MoneyUS(34, 1.16134006075157, 6.30498105348769, 7.66185643887908, 3.203333, 2.716);
                yield return new MoneyUS(35, 1.58110514284502, 6.30011837473626, 7.66977532382846, 3.333333, 2.858);
                yield return new MoneyUS(36, 2.31827626803511, 6.29976981508932, 7.6686545615929, 3.263333, 2.803333);
                yield return new MoneyUS(37, 0.609881951656988, 6.30860322802779, 7.68289710709471, 3.31, 2.909);
                yield return new MoneyUS(38, 0.57169574722451, 6.31631665686078, 7.69598534078877, 3.316667, 2.941333);
                yield return new MoneyUS(39, 1.55463636983875, 6.32280886728332, 7.71315914188775, 3.696667, 3.280667);
                yield return new MoneyUS(40, 2.78982161581016, 6.32523637660053, 7.72068349786114, 3.906667, 3.499333);
                yield return new MoneyUS(41, 0.616331719817964, 6.3302031624436, 7.74547888064933, 3.95, 3.538);
                yield return new MoneyUS(42, 2.2662719726048, 6.33143257123848, 7.75358062718379, 3.933333, 3.481333);
                yield return new MoneyUS(43, 1.77954449610276, 6.34317150118222, 7.76531459579247, 3.91, 3.504);
                yield return new MoneyUS(44, 2.29166341125549, 6.35045679586704, 7.76811037852599, 4.063333, 3.685);
                yield return new MoneyUS(45, 4.28012406375498, 6.34723626296006, 7.78742351939979, 4.3, 3.899667);
                yield return new MoneyUS(46, 1.66644691742466, 6.348849319646, 7.80090020134898, 4.38, 3.879);
                yield return new MoneyUS(47, 2.43894882762561, 6.35441448383309, 7.81822912553473, 4.38, 3.859667);
                yield return new MoneyUS(48, 3.18002662197543, 6.36460641854738, 7.84141430501738, 4.47, 4.158667);
                yield return new MoneyUS(49, 3.82966022687636, 6.3720657517043, 7.86203519676033, 4.97, 4.630667);
                yield return new MoneyUS(50, 4.09644938525613, 6.37256797212336, 7.86380504062964, 5.426667, 4.597333);
                yield return new MoneyUS(51, 3.03638741838199, 6.3618635509748, 7.87325513486884, 5.79, 5.047667);
                yield return new MoneyUS(52, 4.56556716001231, 6.35336877498017, 7.87872357214699, 6, 5.246);
                yield return new MoneyUS(53, 2.11821474795713, 6.3579350602961, 7.88502821579109, 5.45, 4.533667);
                yield return new MoneyUS(54, 1.27478459383141, 6.36850715403866, 7.88945914940452, 4.716667, 3.657333);
                yield return new MoneyUS(55, 3.68029130449106, 6.38108314705653, 7.90082184965834, 4.973333, 4.344667);
                yield return new MoneyUS(56, 4.8459267151177, 6.38536063210569, 7.90658406410226, 5.303333, 4.787333);
                yield return new MoneyUS(57, 6.05630060256033, 6.38256571279037, 7.92011953560236, 5.58, 5.064667);
                yield return new MoneyUS(58, 4.60122775488081, 6.38859126427675, 7.93626693997076, 6.08, 5.51);
                yield return new MoneyUS(59, 4.60822988815472, 6.39638648059478, 7.94335676784084, 5.963333, 5.226333);
                yield return new MoneyUS(60, 5.21447902102139, 6.40468625927027, 7.94509481917843, 5.963333, 5.580667);
                yield return new MoneyUS(61, 4.16477103221347, 6.41215906520361, 7.96018400334576, 6.656667, 6.137667);
                yield return new MoneyUS(62, 5.39973872029034, 6.4066544312179, 7.96130046428094, 7.54, 6.24);
                yield return new MoneyUS(63, 5.83674472553426, 6.39653166565227, 7.96710685369694, 8.486667, 7.046667);
                yield return new MoneyUS(64, 4.62959572481374, 6.39301759660714, 7.96384273523525, 8.62, 7.317667);
                yield return new MoneyUS(65, 5.44672251537417, 6.39015533423632, 7.96130046428094, 8.553333, 7.262667);
                yield return new MoneyUS(66, 6.81784449750236, 6.38021669281611, 7.95840206335537, 8.166667, 6.752333);
                yield return new MoneyUS(67, 2.56513581778943, 6.38707237341665, 7.9707403900071, 7.836667, 6.374667);
                yield return new MoneyUS(68, 4.41499435889092, 6.39382083050546, 7.96321647399426, 6.293333, 5.358333);
                yield return new MoneyUS(69, 7.39992345647078, 6.39187589518744, 7.98613084614881, 4.59, 3.863333);
                yield return new MoneyUS(70, 6.23666951182891, 6.39723852593652, 7.98759241232391, 5.04, 4.206);
                yield return new MoneyUS(71, 4.90548745799479, 6.40210744534837, 7.99372127261592, 5.743333, 5.050333);
                yield return new MoneyUS(72, 2.96470444835801, 6.40395841308831, 7.99877212852842, 5.063333, 4.234333);
                yield return new MoneyUS(73, 5.54532079623087, 6.40951600844825, 8.01872424185962, 4.056667, 3.435333);
                yield return new MoneyUS(74, 3.90053659130363, 6.41585386006298, 8.03582927779987, 4.576667, 3.748333);
                yield return new MoneyUS(75, 3.7182552568952, 6.42724668556159, 8.04744552940809, 4.933333, 4.241333);
                yield return new MoneyUS(76, 6.33204983740523, 6.43574467346328, 8.06322037924303, 5.333333, 4.851333);
                yield return new MoneyUS(77, 5.18783657275304, 6.44229702570876, 8.0874251447849, 6.283333, 5.639667);
                yield return new MoneyUS(78, 7.37104809864011, 6.43584717551225, 8.09181104946771, 7.466667, 6.608333);
                yield return new MoneyUS(79, 7.50450902205682, 6.42866326544073, 8.09080062362508, 9.873333, 8.388333);
                yield return new MoneyUS(80, 9.38113971449663, 6.4175499043581, 8.09836925010508, 8.98, 7.461667);
                yield return new MoneyUS(81, 6.38785122359007, 6.41805094130409, 8.08929840834189, 8.303333, 7.600333);
                yield return new MoneyUS(82, 8.29834015503259, 6.40656093935953, 8.09181104946771, 10.456667, 8.268);
                yield return new MoneyUS(83, 11.8914184683543, 6.38587998790574, 8.0830507924212, 11.533333, 8.286333);
                yield return new MoneyUS(84, 9.65358743678859, 6.37388670432137, 8.07912224355916, 9.05, 7.336);
                yield return new MoneyUS(85, 11.4105585387872, 6.35107287045558, 8.05642676752298, 6.563333, 5.873333);
                yield return new MoneyUS(86, 5.45724844599569, 6.35234642433552, 8.06790157976752, 5.92, 5.400667);
                yield return new MoneyUS(87, 8.35063683603749, 6.35027693927786, 8.08637950561963, 6.666667, 6.336667);
                yield return new MoneyUS(88, 6.72691287973599, 6.34139620433995, 8.09940243361744, 6.12, 5.684333);
                yield return new MoneyUS(89, 5.1718510685145, 6.34186169728584, 8.11871362748179, 5.29, 4.953333);
                yield return new MoneyUS(90, 5.11805797767444, 6.34522346201378, 8.12243060644121, 5.57, 5.168667);
                yield return new MoneyUS(91, 6.20178417211843, 6.34027259903075, 8.12592680270789, 5.53, 5.168667);
                yield return new MoneyUS(92, 6.86144416694603, 6.34203652824224, 8.13631337306638, 4.99, 4.698333);
                yield return new MoneyUS(93, 5.40790499308503, 6.35191217915634, 8.1508718704257, 4.81, 4.624);
                yield return new MoneyUS(94, 8.15039156698738, 6.3490460655214, 8.16763571524637, 5.236667, 4.828667);
                yield return new MoneyUS(95, 6.97459240947182, 6.34840442770196, 8.18155260887488, 5.806667, 5.472);
                yield return new MoneyUS(96, 7.05005262064908, 6.35186503233162, 8.17953625331327, 6.593333, 6.137);
                yield return new MoneyUS(97, 5.64386478323904, 6.35751231946773, 8.18640874858464, 6.796667, 6.408);
                yield return new MoneyUS(98, 10.3705825614718, 6.35358635559966, 8.21797820315073, 7.2, 6.481);
                yield return new MoneyUS(99, 7.7627941371226, 6.35399342716121, 8.22566372723556, 8.083333, 7.315333);
                yield return new MoneyUS(100, 8.68324751511729, 6.34947013406367, 8.23737346290847, 9.896667, 8.680333);
                yield return new MoneyUS(101, 7.82074995684354, 6.34210728935641, 8.23769090643264, 10.096667, 9.357667);
                yield return new MoneyUS(102, 8.54936271628688, 6.34539717141834, 8.23861620821311, 9.853333, 9.372334);
                yield return new MoneyUS(103, 8.80865402972475, 6.34788547590804, 8.24472808476932, 10.603333, 9.631333);
                yield return new MoneyUS(104, 7.95744065078168, 6.33667042973733, 8.24659108894233, 13.096667, 11.803667);
                yield return new MoneyUS(105, 9.21414079029681, 6.33016867316295, 8.25082893764746, 14.253333, 13.458667);
                yield return new MoneyUS(106, 9.45053662192592, 6.29800669329411, 8.22486032074903, 10.75, 10.049333);
                yield return new MoneyUS(107, 9.08664894426927, 6.31209674059635, 8.22510141047576, 9.646667, 9.235333);
                yield return new MoneyUS(108, 10.4795322955688, 6.31290432557971, 8.24499068981284, 14.513333, 13.709667);
                yield return new MoneyUS(109, 11.2514751496516, 6.29608432123228, 8.25855198774887, 14.52, 14.369);
                yield return new MoneyUS(110, 6.9857943620601, 6.30250891153356, 8.25437282294913, 15.35, 14.829);
                yield return new MoneyUS(111, 9.32349038135953, 6.28412880889945, 8.25958758654693, 16.213333, 15.087333);
                yield return new MoneyUS(112, 8.56956630809513, 6.27526806729518, 8.24357180261279, 12.94, 12.022667);
                yield return new MoneyUS(113, 4.53466016925894, 6.28648647315777, 8.2311364640419, 13.696667, 12.895);
                yield return new MoneyUS(114, 5.2402649065403, 6.28298396570641, 8.2351220150717, 13.483333, 12.359);
                yield return new MoneyUS(115, 4.05725368722045, 6.28500534731137, 8.23068376448021, 11.553333, 9.705333);
                yield return new MoneyUS(116, 3.33361757818835, 6.31670265881303, 8.23206784774615, 8.81, 7.935);
                yield return new MoneyUS(117, 4.88249143589243, 6.33222844803767, 8.23840478613458, 8.34, 8.081333);
                yield return new MoneyUS(118, 2.8123136038019, 6.35552872002237, 8.26526428867027, 8.606667, 8.419);
                yield return new MoneyUS(119, 3.918154012975, 6.36898712555201, 8.28005213045817, 9.44, 9.186667);
                yield return new MoneyUS(120, 4.21349624267684, 6.37586651742314, 8.29707007399552, 9.19, 8.793333);
                yield return new MoneyUS(121, 5.62077982308224, 6.37785667140277, 8.31617799217503, 9.45, 9.133333);
                yield return new MoneyUS(122, 4.15853786985778, 6.38430533570653, 8.32941678393932, 10.773333, 9.843333);
                yield return new MoneyUS(123, 4.56260153416856, 6.38247774576208, 8.3348076325742, 11.146667, 10.343333);
                yield return new MoneyUS(124, 2.63701982202917, 6.38653010278623, 8.34145789749702, 9.256667, 8.973333);
                yield return new MoneyUS(125, 4.63993703142904, 6.40052339082679, 8.34801685637197, 8.69, 8.183333);
                yield return new MoneyUS(126, 2.68090496423596, 6.41848625236529, 8.35580303637751, 7.91, 7.523333);
                yield return new MoneyUS(127, 2.80385149316267, 6.4465599618505, 8.36846113761584, 7.723333, 7.103333);
                yield return new MoneyUS(128, 3.92399473433969, 6.4645762277808, 8.3741308085744, 7.7, 7.146667);
                yield return new MoneyUS(129, 1.97260459788886, 6.48098903832579, 8.38719839480005, 7.413333, 6.886667);
                yield return new MoneyUS(130, 1.79879494530937, 6.51525437008478, 8.38656045078078, 6.543333, 6.13);
                yield return new MoneyUS(131, 3.19989770015212, 6.54904636798941, 8.39221936387427, 5.893333, 5.533333);
                yield return new MoneyUS(132, 2.99064871394918, 6.58408641702361, 8.39550002113751, 5.726667, 5.34);
                yield return new MoneyUS(133, 3.5977891145663, 6.60689355493769, 8.40290404501411, 5.95, 5.533333);
                yield return new MoneyUS(134, 2.85257172470459, 6.61719628790055, 8.41522690882643, 6.846667, 5.733333);
                yield return new MoneyUS(135, 3.05515290112552, 6.61121370140615, 8.42492438195282, 7.026667, 6.033333);
                yield return new MoneyUS(136, 3.69791353142936, 6.61241879767399, 8.43933975221137, 7.54, 6.003333);
                yield return new MoneyUS(137, 3.3155764584162, 6.61162184917751, 8.44576163446592, 6.713333, 5.76);
                yield return new MoneyUS(138, 4.49419116628356, 6.61891750313928, 8.45633854314575, 7.253333, 6.23);
                yield return new MoneyUS(139, 4.83478909814465, 6.61984775582594, 8.46263140342355, 8.163333, 6.993333);
                yield return new MoneyUS(140, 3.98989297330239, 6.61293138955326, 8.47213306200964, 8.586667, 7.703333);
                yield return new MoneyUS(141, 5.11210188711075, 6.59875054466047, 8.48003115772747, 9.446667, 8.533333);
                yield return new MoneyUS(142, 4.35469898827705, 6.57727491126538, 8.48446336679332, 9.29, 8.44);
                yield return new MoneyUS(143, 3.7608285872988, 6.57275424025606, 8.48446336679332, 8.39, 7.85);
                yield return new MoneyUS(144, 3.50211033057839, 6.57660551097167, 8.48811447391557, 8.056667, 7.633333);
                yield return new MoneyUS(145, 5.25743109294083, 6.57445243733822, 8.49664348512603, 8.076667, 7.756667);
                yield return new MoneyUS(146, 4.21180327327946, 6.57454631689056, 8.50047420480936, 8.193333, 7.766667);
                yield return new MoneyUS(147, 3.94826996962792, 6.57584068735016, 8.49831613564655, 7.833333, 7.493333);
                yield return new MoneyUS(148, 4.22560511714636, 6.57320499565041, 8.49027410206497, 7.68, 7.023333);
                yield return new MoneyUS(149, 4.84638630431391, 6.57420476384515, 8.485083137498, 6.596667, 6.053333);
                yield return new MoneyUS(150, 2.73976981592376, 6.587025508679, 8.49041791157925, 6.056667, 5.593333);
                yield return new MoneyUS(151, 2.78291638615506, 6.59943580685248, 8.49288000683395, 5.83, 5.406667);
                yield return new MoneyUS(152, 2.46680492788407, 6.61734712586178, 8.49306441983764, 4.916667, 4.583333);
                yield return new MoneyUS(153, 3.77753080335594, 6.64878383080248, 8.50075888495281, 4.19, 3.91);
                yield return new MoneyUS(154, 2.67041429050856, 6.66876561474377, 8.50663767747672, 4.03, 3.723333);
                yield return new MoneyUS(155, 1.35259803620293, 6.69251099457769, 8.51529138412664, 3.41, 3.13);
                yield return new MoneyUS(156, 2.64672396072818, 6.72476035075931, 8.52926009263438, 3.566667, 3.076667);
                yield return new MoneyUS(157, 3.14268520976206, 6.73737817571542, 8.53214091546336, 3.286667, 2.993333);
                yield return new MoneyUS(158, 1.71907139557454, 6.75936772515401, 8.53805408208357, 3.256667, 2.983333);
                yield return new MoneyUS(159, 1.09251399465968, 6.78621288645602, 8.54469162011805, 3.31, 3.02);
                yield return new MoneyUS(160, 1.33873145513093, 6.80602011291089, 8.55986946569667, 3.366667, 3.08);
                yield return new MoneyUS(161, 2.63029940261568, 6.81422666500262, 8.56809540934336, 3.666667, 3.25);
                yield return new MoneyUS(162, 2.93857667339736, 6.81152629786116, 8.57811894435873, 4.726667, 4.036667);
                yield return new MoneyUS(163, 2.07876970352992, 6.8138226560283, 8.58802437217683, 5.213333, 4.51);
                yield return new MoneyUS(164, 1.21785675577506, 6.80721263795447, 8.600393984009, 6.11, 5.283333);
            }
        }
    }
}
