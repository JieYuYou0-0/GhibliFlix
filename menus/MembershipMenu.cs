﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GhibliFlix
{
    internal class MembershipMenu : Menu
    {
        internal MembershipMenu()
        {
            CreateReservationMovie createReservationMenu = new CreateReservationMovie();
            createReservationMenu.PreviousMenu = Init;
            AddMenuOption(MembershipOverview, ConsoleKey.D1);
            AddMenuOption(createReservationMenu.Init, ConsoleKey.D2);
            AddMenuOption(CancelReservation, ConsoleKey.D3);
        }

        internal override void Init()
        {
            Console.Clear();
            Menu.Log("Ponyo opens Membership Menu");
            /* na membership menu krijg je overzicht movies --> movie branch

            PreviousMenu = ;
            */
        }
        internal void MembershipOverview()
        {

        }

        internal void CancelReservation()
        {

        }
    }
}