// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Deaths in London from measles
    /// </summary>

    public class measles
    {
        public readonly int time;
        public readonly string value;

        public measles(int time, string value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<measles> Data
        {
            get
            {
                yield return new measles(1629, "42");
                yield return new measles(1630, "2");
                yield return new measles(1631, "3");
                yield return new measles(1632, "80");
                yield return new measles(1633, "21");
                yield return new measles(1634, "33");
                yield return new measles(1635, "27");
                yield return new measles(1636, "12");
                yield return new measles(1637, null);
                yield return new measles(1638, null);
                yield return new measles(1639, null);
                yield return new measles(1640, null);
                yield return new measles(1641, null);
                yield return new measles(1642, null);
                yield return new measles(1643, null);
                yield return new measles(1644, null);
                yield return new measles(1645, null);
                yield return new measles(1646, null);
                yield return new measles(1647, "5");
                yield return new measles(1648, "92");
                yield return new measles(1649, "3");
                yield return new measles(1650, "33");
                yield return new measles(1651, "33");
                yield return new measles(1652, "62");
                yield return new measles(1653, "8");
                yield return new measles(1654, "52");
                yield return new measles(1655, "11");
                yield return new measles(1656, "153");
                yield return new measles(1657, "15");
                yield return new measles(1658, "80");
                yield return new measles(1659, "6");
                yield return new measles(1660, "74");
                yield return new measles(1661, "188");
                yield return new measles(1662, "20");
                yield return new measles(1663, "42");
                yield return new measles(1664, "311");
                yield return new measles(1665, "7");
                yield return new measles(1666, "3");
                yield return new measles(1667, "83");
                yield return new measles(1668, "200");
                yield return new measles(1669, "15");
                yield return new measles(1670, "295");
                yield return new measles(1671, "7");
                yield return new measles(1672, "118");
                yield return new measles(1673, "15");
                yield return new measles(1674, "795");
                yield return new measles(1675, "1");
                yield return new measles(1676, "83");
                yield return new measles(1677, "87");
                yield return new measles(1678, "93");
                yield return new measles(1679, "117");
                yield return new measles(1680, "49");
                yield return new measles(1681, "121");
                yield return new measles(1682, "50");
                yield return new measles(1683, "39");
                yield return new measles(1684, "6");
                yield return new measles(1685, "197");
                yield return new measles(1686, "25");
                yield return new measles(1687, null);
                yield return new measles(1688, null);
                yield return new measles(1689, null);
                yield return new measles(1690, null);
                yield return new measles(1691, null);
                yield return new measles(1692, null);
                yield return new measles(1693, null);
                yield return new measles(1694, null);
                yield return new measles(1695, null);
                yield return new measles(1696, null);
                yield return new measles(1697, null);
                yield return new measles(1698, null);
                yield return new measles(1699, null);
                yield return new measles(1700, null);
                yield return new measles(1701, "4");
                yield return new measles(1702, "27");
                yield return new measles(1703, "51");
                yield return new measles(1704, "12");
                yield return new measles(1705, "319");
                yield return new measles(1706, "361");
                yield return new measles(1707, "37");
                yield return new measles(1708, "126");
                yield return new measles(1709, "89");
                yield return new measles(1710, "181");
                yield return new measles(1711, "97");
                yield return new measles(1712, "77");
                yield return new measles(1713, "61");
                yield return new measles(1714, "139");
                yield return new measles(1715, "30");
                yield return new measles(1716, "270");
                yield return new measles(1717, "35");
                yield return new measles(1718, "492");
                yield return new measles(1719, "243");
                yield return new measles(1720, "213");
                yield return new measles(1721, "238");
                yield return new measles(1722, "114");
                yield return new measles(1723, "231");
                yield return new measles(1724, "118");
                yield return new measles(1725, "70");
                yield return new measles(1726, "256");
                yield return new measles(1727, "72");
                yield return new measles(1728, "82");
                yield return new measles(1729, "41");
                yield return new measles(1730, "311");
                yield return new measles(1731, "102");
                yield return new measles(1732, "30");
                yield return new measles(1733, "605");
                yield return new measles(1734, "20");
                yield return new measles(1735, "10");
                yield return new measles(1736, "169");
                yield return new measles(1737, "127");
                yield return new measles(1738, "216");
                yield return new measles(1739, "326");
                yield return new measles(1740, "46");
                yield return new measles(1741, "42");
                yield return new measles(1742, "981");
                yield return new measles(1743, "17");
                yield return new measles(1744, "5");
                yield return new measles(1745, "14");
                yield return new measles(1746, "250");
                yield return new measles(1747, "81");
                yield return new measles(1748, "10");
                yield return new measles(1749, "106");
                yield return new measles(1750, "321");
                yield return new measles(1751, "21");
                yield return new measles(1752, "111");
                yield return new measles(1753, "253");
                yield return new measles(1754, "12");
                yield return new measles(1755, "423");
                yield return new measles(1756, "156");
                yield return new measles(1757, "24");
                yield return new measles(1758, "696");
                yield return new measles(1759, "316");
                yield return new measles(1760, "175");
                yield return new measles(1761, "394");
                yield return new measles(1762, "122");
                yield return new measles(1763, "610");
                yield return new measles(1764, "65");
                yield return new measles(1765, "54");
                yield return new measles(1766, "482");
                yield return new measles(1767, "80");
                yield return new measles(1768, "409");
                yield return new measles(1769, "90");
                yield return new measles(1770, "325");
                yield return new measles(1771, "115");
                yield return new measles(1772, "211");
                yield return new measles(1773, "199");
                yield return new measles(1774, "121");
                yield return new measles(1775, "283");
                yield return new measles(1776, "153");
                yield return new measles(1777, "145");
                yield return new measles(1778, "388");
                yield return new measles(1779, "99");
                yield return new measles(1780, "272");
                yield return new measles(1781, "201");
                yield return new measles(1782, "170");
                yield return new measles(1783, "185");
                yield return new measles(1784, "29");
                yield return new measles(1785, "20");
                yield return new measles(1786, "793");
                yield return new measles(1787, "84");
                yield return new measles(1788, "55");
                yield return new measles(1789, "534");
                yield return new measles(1790, "119");
                yield return new measles(1791, "156");
                yield return new measles(1792, "450");
                yield return new measles(1793, "248");
                yield return new measles(1794, "172");
                yield return new measles(1795, "328");
                yield return new measles(1796, "307");
                yield return new measles(1797, "222");
                yield return new measles(1798, "196");
                yield return new measles(1799, "223");
                yield return new measles(1800, "395");
                yield return new measles(1801, "136");
                yield return new measles(1802, "559");
                yield return new measles(1803, "438");
                yield return new measles(1804, "619");
                yield return new measles(1805, "523");
                yield return new measles(1806, "530");
                yield return new measles(1807, "452");
                yield return new measles(1808, "1386");
                yield return new measles(1809, "106");
                yield return new measles(1810, "1031");
                yield return new measles(1811, "235");
                yield return new measles(1812, "427");
                yield return new measles(1813, "550");
                yield return new measles(1814, "817");
                yield return new measles(1815, "711");
                yield return new measles(1816, "1106");
                yield return new measles(1817, "725");
                yield return new measles(1818, "728");
                yield return new measles(1819, "695");
                yield return new measles(1820, "720");
                yield return new measles(1821, "547");
                yield return new measles(1822, "712");
                yield return new measles(1823, "573");
                yield return new measles(1824, "966");
                yield return new measles(1825, "743");
                yield return new measles(1826, "774");
                yield return new measles(1827, "525");
                yield return new measles(1828, "736");
                yield return new measles(1829, "578");
                yield return new measles(1830, "479");
                yield return new measles(1831, "750");
                yield return new measles(1832, null);
                yield return new measles(1833, null);
                yield return new measles(1834, null);
                yield return new measles(1835, null);
                yield return new measles(1836, null);
                yield return new measles(1837, null);
                yield return new measles(1838, null);
                yield return new measles(1839, null);
                yield return new measles(1840, null);
                yield return new measles(1841, "973");
                yield return new measles(1842, "1293");
                yield return new measles(1843, "1442");
                yield return new measles(1844, "1182");
                yield return new measles(1845, "2318");
                yield return new measles(1846, "747");
                yield return new measles(1847, "1778");
                yield return new measles(1848, "1144");
                yield return new measles(1849, "1154");
                yield return new measles(1850, "980");
                yield return new measles(1851, "1297");
                yield return new measles(1852, "595");
                yield return new measles(1853, "978");
                yield return new measles(1854, "1409");
                yield return new measles(1855, "878");
                yield return new measles(1856, "1479");
                yield return new measles(1857, "1341");
                yield return new measles(1858, "2369");
                yield return new measles(1859, "1330");
                yield return new measles(1860, "2090");
                yield return new measles(1861, "1062");
                yield return new measles(1862, "2334");
                yield return new measles(1863, "1634");
                yield return new measles(1864, "2788");
                yield return new measles(1865, "1290");
                yield return new measles(1866, "2220");
                yield return new measles(1867, "1143");
                yield return new measles(1868, "1962");
                yield return new measles(1869, "1456");
                yield return new measles(1870, "1449");
                yield return new measles(1871, "1427");
                yield return new measles(1872, "1680");
                yield return new measles(1873, "2149");
                yield return new measles(1874, "1680");
                yield return new measles(1875, "1408");
                yield return new measles(1876, "1720");
                yield return new measles(1877, "2387");
                yield return new measles(1878, "1500");
                yield return new measles(1879, "2475");
                yield return new measles(1880, "1501");
                yield return new measles(1881, "2533");
                yield return new measles(1882, null);
                yield return new measles(1883, null);
                yield return new measles(1884, null);
                yield return new measles(1885, null);
                yield return new measles(1886, null);
                yield return new measles(1887, null);
                yield return new measles(1888, null);
                yield return new measles(1889, null);
                yield return new measles(1890, null);
                yield return new measles(1891, null);
                yield return new measles(1892, null);
                yield return new measles(1893, null);
                yield return new measles(1894, null);
                yield return new measles(1895, null);
                yield return new measles(1896, null);
                yield return new measles(1897, null);
                yield return new measles(1898, null);
                yield return new measles(1899, null);
                yield return new measles(1900, null);
                yield return new measles(1901, null);
                yield return new measles(1902, null);
                yield return new measles(1903, null);
                yield return new measles(1904, null);
                yield return new measles(1905, null);
                yield return new measles(1906, null);
                yield return new measles(1907, null);
                yield return new measles(1908, null);
                yield return new measles(1909, null);
                yield return new measles(1910, null);
                yield return new measles(1911, "3274");
                yield return new measles(1912, "1151");
                yield return new measles(1913, "2306");
                yield return new measles(1914, "958");
                yield return new measles(1915, "2676");
                yield return new measles(1916, "712");
                yield return new measles(1917, "1819");
                yield return new measles(1918, "1935");
                yield return new measles(1919, "303");
                yield return new measles(1920, "1113");
                yield return new measles(1921, "157");
                yield return new measles(1922, "1656");
                yield return new measles(1923, "154");
                yield return new measles(1924, "1539");
                yield return new measles(1925, "117");
                yield return new measles(1926, "1170");
                yield return new measles(1927, "53");
                yield return new measles(1928, "1480");
                yield return new measles(1929, "112");
                yield return new measles(1930, "1113");
                yield return new measles(1931, "56");
                yield return new measles(1932, "885");
                yield return new measles(1933, "62");
                yield return new measles(1934, "906");
                yield return new measles(1935, "10");
                yield return new measles(1936, "596");
                yield return new measles(1937, "15");
                yield return new measles(1938, "245");
                yield return new measles(1939, "2");
            }
        }
    }
}
