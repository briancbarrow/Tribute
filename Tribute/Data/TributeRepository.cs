using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tribute.Models;

namespace Tribute.Data
{
    public class TributeRepository
    {
        private static SingleTribute[] _tributes = new SingleTribute[]
        {
            new SingleTribute()
            {
                Id = 1,
                TributeTitle = "His Holiness The Dalai Lama",
                BioDescriptionHtml = "Tenzin Gyatso is the current and 14th Dalai Lama",
                BioDates = new BioDate[]
               {
                    new BioDate() { Year = "1935", Event = "Born in Taktser village, Amdo, Tibet." },
                    new BioDate() { Year = "1937", Event = "Selected as the successor of the 13th Dalai Lama" },
                    new BioDate() { Year = "1939", Event = "Formally recognized as the 14th Dalai Lama" },
                    new BioDate() { Year = "1950", Event = "Assumed full temporal/political duties" },
                    new BioDate() { Year = "1959", Event = "Fled to India" },
                    new BioDate() { Year = "1989", Event = "Received Nobel Peace Prize" },
               },
                ImageLink = "dalai-lama.jpg",
                ExternalLink = "https://en.wikipedia.org/wiki/14th_Dalai_Lama"
            },

            new SingleTribute()
            {
                Id = 2,
                TributeTitle = "Samuel Clemens (Mark Twain)",
                BioDescriptionHtml = "Mark Twain, was an American writer, humorist, entrepreneur, publisher, and lecturer",
                BioDates = new BioDate[]
               {
                    new BioDate() { Year = "1835", Event = "Born in Florida, Missouri, USA." },
                    new BioDate() { Year = "1870", Event = "Married to wife Olivia Langdon." },
                    new BioDate() { Year = "1876", Event = "The Adventures of Tom Sawyer published." },
                    new BioDate() { Year = "1884", Event = "The Adventures of Huckleberry Finn published." },
                    new BioDate() { Year = "1904", Event = "Wife Olivia died." },
                    new BioDate() { Year = "1910", Event = "Died in Redding, Connecticut, USA." },
               },
                ImageLink = "mark-twain.jpg",
                ExternalLink = "https://en.wikipedia.org/wiki/Mark_Twain"
            },

        new SingleTribute()
        {
            Id = 3,
            TributeTitle = "Frederick Douglass",
                BioDescriptionHtml = "Frederick Douglass was an African-American social reformer, abolitionist, orator, writer, and statesman",
                BioDates = new BioDate[]
               {
                    new BioDate() { Year = "1818", Event = "Born in Talbot County, Maryland, USA." },
                    new BioDate() { Year = "1838", Event = "Successfully escaped from slavery. Later this same year he married Anna Murray." },
                    new BioDate() { Year = "1845", Event = "Published his autobiography 'Narrative of the Life of Frederick Douglass, an American Slave'" },
                    new BioDate() { Year = "1851", Event = "Merged his newspaper 'North Star' with Gerrit Smith's 'Liberty Party Paper' to form 'Frederick Douglass' Paper', which was published until 1860" },
                    new BioDate() { Year = "1876", Event = "Delivered keynote speec at the unveiling of the Emancipation Memorial" },
                    new BioDate() { Year = "1895", Event = "Died in Washington, D.C., USA" },
               },
                ImageLink = "douglass.jpg",
                ExternalLink = "https://en.wikipedia.org/wiki/Frederick_Douglass"
            }
        };



        public SingleTribute GetTribute(int id)
        {
            SingleTribute tributeToReturn = null;

            foreach (var tribute in _tributes)
            {
                if (tribute.Id == id)
                {
                    tributeToReturn = tribute;
                }
            }

            return tributeToReturn;
        }
    }
}