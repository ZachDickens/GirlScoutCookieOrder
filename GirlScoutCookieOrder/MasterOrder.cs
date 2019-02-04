using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookieOrder
{
    public class MasterOrder
    {
        public List<CookieOrder> orders = new List<CookieOrder>();

        public MasterOrder()
        {

        }


        public void AddOrder(CookieOrder theOrder)
        {
            orders.Add(theOrder);
        }
        public int GetTotalBoxes()
        {
            int numberofboxes = 0;
            for(int i =0; i < orders.Count; i++)
            {
                numberofboxes += orders[i].NumberOfBoxesPurchased;
            }
            return numberofboxes;
        }
        public void RemoveVariety(string variety)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].variety.Equals(variety))
                {
                    orders.RemoveAt(i);
                }
            }
        }
        public int GetVarietyBoxes(string variety)
        {
            return 0;
        }
        public void ShowOrder()
        {

        }


    }



}
