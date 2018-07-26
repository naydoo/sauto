using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Bla
    {
        public IWebDriver driver = new ChromeDriver();
        public string login = "loginviewBtn";
        public string username = "loginTxt";
        public string password = "passwordTxt";
        public string menu = "menuToggleShell";
        public string logout = "menuLogout";
        public static string site = "https://m.bingoliner.com/#login";
        

    }
}
