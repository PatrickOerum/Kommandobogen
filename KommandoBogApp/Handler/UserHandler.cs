﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Streaming.Adaptive;
using KommandoBogApp.Model;
using KommandoBogApp.View;
using KommandoBogApp.ViewModel;

namespace KommandoBogApp.Handler
{
    public class UserHandler
    {
        public static UserViewModel UserVM { get; set; }

        public UserHandler(UserViewModel uSW)
        {
            UserVM = uSW;
        }

        public void CreateUser()
        {
          
            if (UserVM.Type == "Admin")
            {
                Admin admin = new Admin(UserVM.ViewMaNr, UserVM.ViewNavn, UserVM.ViewTlf, UserVM.ViewAdresse, UserVM.ViewEmail);
                UserVM.UserCatalogSingleton.AddUser(admin);
                AddUserToAfdeling(admin);
                admin.Afd = UserVM.Afdeling;

            }
            else if (UserVM.Type == "Leader")
            {
                Leader leader = new Leader(UserVM.ViewMaNr, UserVM.ViewNavn, UserVM.ViewTlf, UserVM.ViewAdresse, UserVM.ViewEmail);
                UserVM.UserCatalogSingleton.AddUser(leader);
                AddUserToAfdeling(leader); 
                leader.Afd = UserVM.Afdeling;


            }
            else if (UserVM.Type == "Regular")
            {
                Regular regular= new Regular(UserVM.ViewMaNr, UserVM.ViewNavn, UserVM.ViewTlf, UserVM.ViewAdresse, UserVM.ViewEmail);
                UserVM.UserCatalogSingleton.AddUser(regular);
                AddUserToAfdeling(regular);
                regular.Afd = UserVM.Afdeling;
            }

        }

        public void DeleteUser()
        {
            UserVM.UserCatalogSingleton.RemoveUser(UserVM.SelectedUser);
        }

        public void AddUserToAfdeling(User user)
        {
            UserVM.Afdeling.AddUserToList(user);
        }

        public static void FixDaysWithActivities()
        {
            
            foreach (var Users in UserVM.UserCatalogSingleton.UserList)
            {
                Users.DaysWithActivities.Clear();
                Users.FillDaysWithActivities();
                foreach (var Activities in Users.Activities)
                {
                    foreach (var Dates in Activities.Dates)
                    {
                        if (Dates.Month == HubTest.ShownMonth.Month && Dates.Year == HubTest.ShownYear.Year)
                        {
                            Users.DaysWithActivities[Dates.Day - 1] = Activities;
                        }
                    }
                }
            }
        }

    }
}
