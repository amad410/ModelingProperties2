﻿using OpenQA.Selenium;
using StatsRoyale.SeleniumFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsRoyale.SeleniumFramework.Pages
{
    /// <summary>
    /// This is the page class model of the Card Details Page. It inherits from the BasePage class like other 
    /// classes to have access to common page things and actions that can be performed on any web page. It also has 
    /// access to the navigate using the navigational header.  The specific thing this class does is return to you 
    /// card properties based on whatever card you click. This page object will return back to the properties of
    /// base card model which will be overriden by the values of the elements it has retrieved from the UI view
    /// once you navigate to the Card Details page in the UI. The overridden properties from the base card model can then
    /// be used as actual properties retrieved from the UI and compared against the expected model properties of the card you
    /// clicked on.
    /// </summary>
    public class CardDetailsPage : BasePage
    {
        public IWebDriver _driver;
        public CardDetailsPageMap _Map;
        //Declaring a card reference from the abstract card class. 
        Card _card = null;
        public CardDetailsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            _Map = new CardDetailsPageMap(_driver);
        }

        public IWebElement GetCardRarity()
        {
            return _Map.CardRarity;
        }
        public string GetCardCategory()
        {
            var category = GetCardRarity().Text.Split(',')[0];
            return category;
        }
        public string GetCardArena()
        {
            var arena = GetCardRarity().Text.Split(',')[1];
            return arena;
        }


    }
    public class CardDetailsPageMap
    {
        public IWebDriver _driver;
        public CardDetailsPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement CardRarity => _driver.FindElement(By.CssSelector("div[class='card__rarity']"));

        public IWebElement CardName => _driver.FindElement(By.CssSelector(".ui__headerMedium.card__cardName"));
        public IWebElement CardRarityStatus => _driver.FindElement(By.CssSelector(".card__rarityCaption div.card__count"));
    }
}
