using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습
{
    class GiftBoxManager
    {
        public void SetInit() 
        {
            GiftBox addressA = GiftBoxMaker("A 친구야 잘 지내지?", 110000, Item_Grade.NORMAL);
            GiftBox addressB = GiftBoxMaker("B 친구야 잘 지내지?", 120000, Item_Grade.RARE);
            GiftBox addressC = GiftBoxMaker("C 친구야 잘 지내지?", 130000, Item_Grade.UNIQUE);

            Console.WriteLine($"addressC : letter :{addressC.Letter} item : {addressC.Grade}");
        }
        private GiftBox GiftBoxMaker(string letter, int money, Item_Grade itemGrade)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money,
                Grade = itemGrade
            };

            return addressA;
        }
    }

}
