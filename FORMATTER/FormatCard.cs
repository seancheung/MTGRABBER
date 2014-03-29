using MODEL;
using System.Collections.Generic;

namespace FORMATTER
{
    public class FormatCard
    {
        /// <summary>
        /// Get a list of cards by set
        /// </summary>
        /// <param name="setname">Full english set name</param>
        /// <param name="setcode">Setcode in capital</param>
        /// <param name="lang">Language</param>
        /// <returns>A list of fully formatted cards</returns>
        public static List<Card> GetCards(string setname, string setcode, LANGUAGE lang = LANGUAGE.Chinese_Simplified)
        {
            List<Card> cards = new List<Card>();
            cards = FormatID.GetCards(setname, setcode);
            cards = FormatDetail.GetCards(cards);
            cards = FormatForeignID.GetCards(cards, lang);
            cards = FormatForeignDetail.GetCards(cards);
            cards = FormatLegacy.GetCards(cards);
            cards = FormatEx.Format(cards);

            return cards;
        }
    }
}
