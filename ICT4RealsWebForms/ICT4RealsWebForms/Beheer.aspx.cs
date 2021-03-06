﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.Remise;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.DataBase;
using System.Drawing;
using System.Diagnostics;

namespace ICT4RealsWebForms
{
    public partial class About : Page
    {
        TRdatabase tramDatabase = new TRdatabase();
        RAdatabase railDatabase = new RAdatabase();
        PAdatabase padatabase = new PAdatabase();
        InUitRij inuitrij = new InUitRij();
        Administration administration = new Administration();
        int number; //test for tryparse
        int index;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Administration.LoggedInUser != null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {


                ddlDetailsStatus.Items.Clear();
                ddlDetailsStatus.Items.Add("Ok");
                ddlDetailsStatus.Items.Add("Vies");
                ddlDetailsStatus.Items.Add("Defect");
                ddlDetailsStatus.Items.Add("Vies en Defect");
            }
            else
            {
                if (Session["index"] != null)
                {
                    index = (int)Session["index"];
                    //simulatielbl.Text = "Simulatie stap: " + index;

                }
            }

            //put items in dropdownlist tram details
            //delete items first


            #region
            //put items in dropdownlist for each rails 1
            ddlDetailsLocation.Items.Add("1201");
            ddlDetailsLocation.Items.Add("1301");
            ddlDetailsLocation.Items.Add("1401");
            ddlDetailsLocation.Items.Add("1501");
            ddlDetailsLocation.Items.Add("1601");
            ddlDetailsLocation.Items.Add("1701");
            ddlDetailsLocation.Items.Add("1801");
            ddlDetailsLocation.Items.Add("1901");
            ddlDetailsLocation.Items.Add("2001");
            ddlDetailsLocation.Items.Add("2101");
            ddlDetailsLocation.Items.Add("3001");
            ddlDetailsLocation.Items.Add("3002");
            ddlDetailsLocation.Items.Add("3003");
            ddlDetailsLocation.Items.Add("3101");
            ddlDetailsLocation.Items.Add("3102");
            ddlDetailsLocation.Items.Add("3103");
            ddlDetailsLocation.Items.Add("3201");
            ddlDetailsLocation.Items.Add("3202");
            ddlDetailsLocation.Items.Add("3203");
            ddlDetailsLocation.Items.Add("3301");
            ddlDetailsLocation.Items.Add("3302");
            ddlDetailsLocation.Items.Add("3303");
            ddlDetailsLocation.Items.Add("3304");
            ddlDetailsLocation.Items.Add("3401");
            ddlDetailsLocation.Items.Add("3402");
            ddlDetailsLocation.Items.Add("3403");
            ddlDetailsLocation.Items.Add("3404");
            ddlDetailsLocation.Items.Add("3501");
            ddlDetailsLocation.Items.Add("3502");
            ddlDetailsLocation.Items.Add("3503");
            ddlDetailsLocation.Items.Add("3504");
            ddlDetailsLocation.Items.Add("3601");
            ddlDetailsLocation.Items.Add("3602");
            ddlDetailsLocation.Items.Add("3603");
            ddlDetailsLocation.Items.Add("3604");
            ddlDetailsLocation.Items.Add("3701");
            ddlDetailsLocation.Items.Add("3702");
            ddlDetailsLocation.Items.Add("3703");
            ddlDetailsLocation.Items.Add("3704");
            ddlDetailsLocation.Items.Add("3801");
            ddlDetailsLocation.Items.Add("3802");
            ddlDetailsLocation.Items.Add("3803");
            ddlDetailsLocation.Items.Add("3804");
            ddlDetailsLocation.Items.Add("4001");
            ddlDetailsLocation.Items.Add("4002");
            ddlDetailsLocation.Items.Add("4003");
            ddlDetailsLocation.Items.Add("4004");
            ddlDetailsLocation.Items.Add("4005");
            ddlDetailsLocation.Items.Add("4006");
            ddlDetailsLocation.Items.Add("4007");
            ddlDetailsLocation.Items.Add("4101");
            ddlDetailsLocation.Items.Add("4102");
            ddlDetailsLocation.Items.Add("4103");
            ddlDetailsLocation.Items.Add("4104");
            ddlDetailsLocation.Items.Add("4201");
            ddlDetailsLocation.Items.Add("4202");
            ddlDetailsLocation.Items.Add("4203");
            ddlDetailsLocation.Items.Add("4204");
            ddlDetailsLocation.Items.Add("4301");
            ddlDetailsLocation.Items.Add("4302");
            ddlDetailsLocation.Items.Add("4303");
            ddlDetailsLocation.Items.Add("4304");
            ddlDetailsLocation.Items.Add("4401");
            ddlDetailsLocation.Items.Add("4402");
            ddlDetailsLocation.Items.Add("4403");
            ddlDetailsLocation.Items.Add("4404");
            ddlDetailsLocation.Items.Add("4501");
            ddlDetailsLocation.Items.Add("4502");
            ddlDetailsLocation.Items.Add("4503");
            ddlDetailsLocation.Items.Add("4504");
            ddlDetailsLocation.Items.Add("4505");
            ddlDetailsLocation.Items.Add("4506");
            ddlDetailsLocation.Items.Add("4507");
            ddlDetailsLocation.Items.Add("4508");
            ddlDetailsLocation.Items.Add("4509");
            ddlDetailsLocation.Items.Add("5101");
            ddlDetailsLocation.Items.Add("5102");
            ddlDetailsLocation.Items.Add("5103");
            ddlDetailsLocation.Items.Add("5104");
            ddlDetailsLocation.Items.Add("5105");
            ddlDetailsLocation.Items.Add("5201");
            ddlDetailsLocation.Items.Add("5202");
            ddlDetailsLocation.Items.Add("5203");
            ddlDetailsLocation.Items.Add("5204");
            ddlDetailsLocation.Items.Add("5205");
            ddlDetailsLocation.Items.Add("5206");
            ddlDetailsLocation.Items.Add("5301");
            ddlDetailsLocation.Items.Add("5302");
            ddlDetailsLocation.Items.Add("5303");
            ddlDetailsLocation.Items.Add("5304");
            ddlDetailsLocation.Items.Add("5305");
            ddlDetailsLocation.Items.Add("5306");
            ddlDetailsLocation.Items.Add("5401");
            ddlDetailsLocation.Items.Add("5402");
            ddlDetailsLocation.Items.Add("5403");
            ddlDetailsLocation.Items.Add("5404");
            ddlDetailsLocation.Items.Add("5405");
            ddlDetailsLocation.Items.Add("5406");
            ddlDetailsLocation.Items.Add("5407");
            ddlDetailsLocation.Items.Add("5501");
            ddlDetailsLocation.Items.Add("5502");
            ddlDetailsLocation.Items.Add("5503");
            ddlDetailsLocation.Items.Add("5504");
            ddlDetailsLocation.Items.Add("5505");
            ddlDetailsLocation.Items.Add("5506");
            ddlDetailsLocation.Items.Add("5507");
            ddlDetailsLocation.Items.Add("5601");
            ddlDetailsLocation.Items.Add("5602");
            ddlDetailsLocation.Items.Add("5603");
            ddlDetailsLocation.Items.Add("5604");
            ddlDetailsLocation.Items.Add("5605");
            ddlDetailsLocation.Items.Add("5606");
            ddlDetailsLocation.Items.Add("5607");
            ddlDetailsLocation.Items.Add("5701");
            ddlDetailsLocation.Items.Add("5702");
            ddlDetailsLocation.Items.Add("5703");
            ddlDetailsLocation.Items.Add("5704");
            ddlDetailsLocation.Items.Add("5705");
            ddlDetailsLocation.Items.Add("5706");
            ddlDetailsLocation.Items.Add("5707");
            ddlDetailsLocation.Items.Add("5708");
            ddlDetailsLocation.Items.Add("5801");
            ddlDetailsLocation.Items.Add("5802");
            ddlDetailsLocation.Items.Add("5803");
            ddlDetailsLocation.Items.Add("5804");
            ddlDetailsLocation.Items.Add("5805");
            ddlDetailsLocation.Items.Add("6101");
            ddlDetailsLocation.Items.Add("6102");
            ddlDetailsLocation.Items.Add("6201");
            ddlDetailsLocation.Items.Add("6202");
            ddlDetailsLocation.Items.Add("6301");
            ddlDetailsLocation.Items.Add("6302");
            ddlDetailsLocation.Items.Add("6303");
            ddlDetailsLocation.Items.Add("6304");
            ddlDetailsLocation.Items.Add("6401");
            ddlDetailsLocation.Items.Add("6402");
            ddlDetailsLocation.Items.Add("6403");
            ddlDetailsLocation.Items.Add("6404");
            ddlDetailsLocation.Items.Add("7401");
            ddlDetailsLocation.Items.Add("7402");
            ddlDetailsLocation.Items.Add("7403");
            ddlDetailsLocation.Items.Add("7501");
            ddlDetailsLocation.Items.Add("7502");
            ddlDetailsLocation.Items.Add("7503");
            ddlDetailsLocation.Items.Add("7504");
            ddlDetailsLocation.Items.Add("7601");
            ddlDetailsLocation.Items.Add("7602");
            ddlDetailsLocation.Items.Add("7603");
            ddlDetailsLocation.Items.Add("7604");
            ddlDetailsLocation.Items.Add("7605");
            ddlDetailsLocation.Items.Add("7701");
            ddlDetailsLocation.Items.Add("7702");
            ddlDetailsLocation.Items.Add("7703");
            ddlDetailsLocation.Items.Add("7704");
            ddlDetailsLocation.Items.Add("7705");
            #endregion 

            //put items in dropdownlist add tram
            //delete all items first
            if (!IsPostBack)
            {
                ddlAddStatus.Items.Clear();
                ddlAddStatus.Items.Add("Ok");
                ddlAddStatus.Items.Add("Vies");
                ddlAddStatus.Items.Add("Defect");
                ddlAddStatus.Items.Add("Vies en Defect");
            }

            #region
            //put items in dropdownlist for each rails 1
            ddlAddLocation.Items.Add("1201");
            ddlAddLocation.Items.Add("1301");
            ddlAddLocation.Items.Add("1401");
            ddlAddLocation.Items.Add("1501");
            ddlAddLocation.Items.Add("1601");
            ddlAddLocation.Items.Add("1701");
            ddlAddLocation.Items.Add("1801");
            ddlAddLocation.Items.Add("1901");
            ddlAddLocation.Items.Add("2001");
            ddlAddLocation.Items.Add("2101");
            ddlAddLocation.Items.Add("3001");
            ddlAddLocation.Items.Add("3002");
            ddlAddLocation.Items.Add("3003");
            ddlAddLocation.Items.Add("3101");
            ddlAddLocation.Items.Add("3102");
            ddlAddLocation.Items.Add("3103");
            ddlAddLocation.Items.Add("3201");
            ddlAddLocation.Items.Add("3202");
            ddlAddLocation.Items.Add("3203");
            ddlAddLocation.Items.Add("3301");
            ddlAddLocation.Items.Add("3302");
            ddlAddLocation.Items.Add("3303");
            ddlAddLocation.Items.Add("3304");
            ddlAddLocation.Items.Add("3401");
            ddlAddLocation.Items.Add("3402");
            ddlAddLocation.Items.Add("3403");
            ddlAddLocation.Items.Add("3404");
            ddlAddLocation.Items.Add("3501");
            ddlAddLocation.Items.Add("3502");
            ddlAddLocation.Items.Add("3503");
            ddlAddLocation.Items.Add("3504");
            ddlAddLocation.Items.Add("3601");
            ddlAddLocation.Items.Add("3602");
            ddlAddLocation.Items.Add("3603");
            ddlAddLocation.Items.Add("3604");
            ddlAddLocation.Items.Add("3701");
            ddlAddLocation.Items.Add("3702");
            ddlAddLocation.Items.Add("3703");
            ddlAddLocation.Items.Add("3704");
            ddlAddLocation.Items.Add("3801");
            ddlAddLocation.Items.Add("3802");
            ddlAddLocation.Items.Add("3803");
            ddlAddLocation.Items.Add("3804");
            ddlAddLocation.Items.Add("4001");
            ddlAddLocation.Items.Add("4002");
            ddlAddLocation.Items.Add("4003");
            ddlAddLocation.Items.Add("4004");
            ddlAddLocation.Items.Add("4005");
            ddlAddLocation.Items.Add("4006");
            ddlAddLocation.Items.Add("4007");
            ddlAddLocation.Items.Add("4101");
            ddlAddLocation.Items.Add("4102");
            ddlAddLocation.Items.Add("4103");
            ddlAddLocation.Items.Add("4104");
            ddlAddLocation.Items.Add("4201");
            ddlAddLocation.Items.Add("4202");
            ddlAddLocation.Items.Add("4203");
            ddlAddLocation.Items.Add("4204");
            ddlAddLocation.Items.Add("4301");
            ddlAddLocation.Items.Add("4302");
            ddlAddLocation.Items.Add("4303");
            ddlAddLocation.Items.Add("4304");
            ddlAddLocation.Items.Add("4401");
            ddlAddLocation.Items.Add("4402");
            ddlAddLocation.Items.Add("4403");
            ddlAddLocation.Items.Add("4404");
            ddlAddLocation.Items.Add("4501");
            ddlAddLocation.Items.Add("4502");
            ddlAddLocation.Items.Add("4503");
            ddlAddLocation.Items.Add("4504");
            ddlAddLocation.Items.Add("4505");
            ddlAddLocation.Items.Add("4506");
            ddlAddLocation.Items.Add("4507");
            ddlAddLocation.Items.Add("4508");
            ddlAddLocation.Items.Add("4509");
            ddlAddLocation.Items.Add("5101");
            ddlAddLocation.Items.Add("5102");
            ddlAddLocation.Items.Add("5103");
            ddlAddLocation.Items.Add("5104");
            ddlAddLocation.Items.Add("5105");
            ddlAddLocation.Items.Add("5201");
            ddlAddLocation.Items.Add("5202");
            ddlAddLocation.Items.Add("5203");
            ddlAddLocation.Items.Add("5204");
            ddlAddLocation.Items.Add("5205");
            ddlAddLocation.Items.Add("5206");
            ddlAddLocation.Items.Add("5301");
            ddlAddLocation.Items.Add("5302");
            ddlAddLocation.Items.Add("5303");
            ddlAddLocation.Items.Add("5304");
            ddlAddLocation.Items.Add("5305");
            ddlAddLocation.Items.Add("5306");
            ddlAddLocation.Items.Add("5401");
            ddlAddLocation.Items.Add("5402");
            ddlAddLocation.Items.Add("5403");
            ddlAddLocation.Items.Add("5404");
            ddlAddLocation.Items.Add("5405");
            ddlAddLocation.Items.Add("5406");
            ddlAddLocation.Items.Add("5407");
            ddlAddLocation.Items.Add("5501");
            ddlAddLocation.Items.Add("5502");
            ddlAddLocation.Items.Add("5503");
            ddlAddLocation.Items.Add("5504");
            ddlAddLocation.Items.Add("5505");
            ddlAddLocation.Items.Add("5506");
            ddlAddLocation.Items.Add("5507");
            ddlAddLocation.Items.Add("5601");
            ddlAddLocation.Items.Add("5602");
            ddlAddLocation.Items.Add("5603");
            ddlAddLocation.Items.Add("5604");
            ddlAddLocation.Items.Add("5605");
            ddlAddLocation.Items.Add("5606");
            ddlAddLocation.Items.Add("5607");
            ddlAddLocation.Items.Add("5701");
            ddlAddLocation.Items.Add("5702");
            ddlAddLocation.Items.Add("5703");
            ddlAddLocation.Items.Add("5704");
            ddlAddLocation.Items.Add("5705");
            ddlAddLocation.Items.Add("5706");
            ddlAddLocation.Items.Add("5707");
            ddlAddLocation.Items.Add("5708");
            ddlAddLocation.Items.Add("5801");
            ddlAddLocation.Items.Add("5802");
            ddlAddLocation.Items.Add("5803");
            ddlAddLocation.Items.Add("5804");
            ddlAddLocation.Items.Add("5805");
            ddlAddLocation.Items.Add("6101");
            ddlAddLocation.Items.Add("6102");
            ddlAddLocation.Items.Add("6201");
            ddlAddLocation.Items.Add("6202");
            ddlAddLocation.Items.Add("6301");
            ddlAddLocation.Items.Add("6302");
            ddlAddLocation.Items.Add("6303");
            ddlAddLocation.Items.Add("6304");
            ddlAddLocation.Items.Add("6401");
            ddlAddLocation.Items.Add("6402");
            ddlAddLocation.Items.Add("6403");
            ddlAddLocation.Items.Add("6404");
            ddlAddLocation.Items.Add("7401");
            ddlAddLocation.Items.Add("7402");
            ddlAddLocation.Items.Add("7403");
            ddlAddLocation.Items.Add("7501");
            ddlAddLocation.Items.Add("7502");
            ddlAddLocation.Items.Add("7503");
            ddlAddLocation.Items.Add("7504");
            ddlAddLocation.Items.Add("7601");
            ddlAddLocation.Items.Add("7602");
            ddlAddLocation.Items.Add("7603");
            ddlAddLocation.Items.Add("7604");
            ddlAddLocation.Items.Add("7605");
            ddlAddLocation.Items.Add("7701");
            ddlAddLocation.Items.Add("7702");
            ddlAddLocation.Items.Add("7703");
            ddlAddLocation.Items.Add("7704");
            ddlAddLocation.Items.Add("7705");
            #endregion

            //put items in dropdownlist rails
            //delete all items first
            if (!IsPostBack)
            {
                ddlStatusStatus.Items.Clear();
                ddlStatusStatus.Items.Add("Blokkeer");
                ddlStatusStatus.Items.Add("Deblokkeer");
            }

            #region
            //put items in dropdownlist for each rails 1
            ddlDriveInLocation.Items.Add("1201");
            ddlDriveInLocation.Items.Add("1301");
            ddlDriveInLocation.Items.Add("1401");
            ddlDriveInLocation.Items.Add("1501");
            ddlDriveInLocation.Items.Add("1601");
            ddlDriveInLocation.Items.Add("1701");
            ddlDriveInLocation.Items.Add("1801");
            ddlDriveInLocation.Items.Add("1901");
            ddlDriveInLocation.Items.Add("2001");
            ddlDriveInLocation.Items.Add("2101");
            ddlDriveInLocation.Items.Add("3001");
            ddlDriveInLocation.Items.Add("3002");
            ddlDriveInLocation.Items.Add("3003");
            ddlDriveInLocation.Items.Add("3101");
            ddlDriveInLocation.Items.Add("3102");
            ddlDriveInLocation.Items.Add("3103");
            ddlDriveInLocation.Items.Add("3201");
            ddlDriveInLocation.Items.Add("3202");
            ddlDriveInLocation.Items.Add("3203");
            ddlDriveInLocation.Items.Add("3301");
            ddlDriveInLocation.Items.Add("3302");
            ddlDriveInLocation.Items.Add("3303");
            ddlDriveInLocation.Items.Add("3304");
            ddlDriveInLocation.Items.Add("3401");
            ddlDriveInLocation.Items.Add("3402");
            ddlDriveInLocation.Items.Add("3403");
            ddlDriveInLocation.Items.Add("3404");
            ddlDriveInLocation.Items.Add("3501");
            ddlDriveInLocation.Items.Add("3502");
            ddlDriveInLocation.Items.Add("3503");
            ddlDriveInLocation.Items.Add("3504");
            ddlDriveInLocation.Items.Add("3601");
            ddlDriveInLocation.Items.Add("3602");
            ddlDriveInLocation.Items.Add("3603");
            ddlDriveInLocation.Items.Add("3604");
            ddlDriveInLocation.Items.Add("3701");
            ddlDriveInLocation.Items.Add("3702");
            ddlDriveInLocation.Items.Add("3703");
            ddlDriveInLocation.Items.Add("3704");
            ddlDriveInLocation.Items.Add("3801");
            ddlDriveInLocation.Items.Add("3802");
            ddlDriveInLocation.Items.Add("3803");
            ddlDriveInLocation.Items.Add("3804");
            ddlDriveInLocation.Items.Add("4001");
            ddlDriveInLocation.Items.Add("4002");
            ddlDriveInLocation.Items.Add("4003");
            ddlDriveInLocation.Items.Add("4004");
            ddlDriveInLocation.Items.Add("4005");
            ddlDriveInLocation.Items.Add("4006");
            ddlDriveInLocation.Items.Add("4007");
            ddlDriveInLocation.Items.Add("4101");
            ddlDriveInLocation.Items.Add("4102");
            ddlDriveInLocation.Items.Add("4103");
            ddlDriveInLocation.Items.Add("4104");
            ddlDriveInLocation.Items.Add("4201");
            ddlDriveInLocation.Items.Add("4202");
            ddlDriveInLocation.Items.Add("4203");
            ddlDriveInLocation.Items.Add("4204");
            ddlDriveInLocation.Items.Add("4301");
            ddlDriveInLocation.Items.Add("4302");
            ddlDriveInLocation.Items.Add("4303");
            ddlDriveInLocation.Items.Add("4304");
            ddlDriveInLocation.Items.Add("4401");
            ddlDriveInLocation.Items.Add("4402");
            ddlDriveInLocation.Items.Add("4403");
            ddlDriveInLocation.Items.Add("4404");
            ddlDriveInLocation.Items.Add("4501");
            ddlDriveInLocation.Items.Add("4502");
            ddlDriveInLocation.Items.Add("4503");
            ddlDriveInLocation.Items.Add("4504");
            ddlDriveInLocation.Items.Add("4505");
            ddlDriveInLocation.Items.Add("4506");
            ddlDriveInLocation.Items.Add("4507");
            ddlDriveInLocation.Items.Add("4508");
            ddlDriveInLocation.Items.Add("4509");
            ddlDriveInLocation.Items.Add("5101");
            ddlDriveInLocation.Items.Add("5102");
            ddlDriveInLocation.Items.Add("5103");
            ddlDriveInLocation.Items.Add("5104");
            ddlDriveInLocation.Items.Add("5105");
            ddlDriveInLocation.Items.Add("5201");
            ddlDriveInLocation.Items.Add("5202");
            ddlDriveInLocation.Items.Add("5203");
            ddlDriveInLocation.Items.Add("5204");
            ddlDriveInLocation.Items.Add("5205");
            ddlDriveInLocation.Items.Add("5206");
            ddlDriveInLocation.Items.Add("5301");
            ddlDriveInLocation.Items.Add("5302");
            ddlDriveInLocation.Items.Add("5303");
            ddlDriveInLocation.Items.Add("5304");
            ddlDriveInLocation.Items.Add("5305");
            ddlDriveInLocation.Items.Add("5306");
            ddlDriveInLocation.Items.Add("5401");
            ddlDriveInLocation.Items.Add("5402");
            ddlDriveInLocation.Items.Add("5403");
            ddlDriveInLocation.Items.Add("5404");
            ddlDriveInLocation.Items.Add("5405");
            ddlDriveInLocation.Items.Add("5406");
            ddlDriveInLocation.Items.Add("5407");
            ddlDriveInLocation.Items.Add("5501");
            ddlDriveInLocation.Items.Add("5502");
            ddlDriveInLocation.Items.Add("5503");
            ddlDriveInLocation.Items.Add("5504");
            ddlDriveInLocation.Items.Add("5505");
            ddlDriveInLocation.Items.Add("5506");
            ddlDriveInLocation.Items.Add("5507");
            ddlDriveInLocation.Items.Add("5601");
            ddlDriveInLocation.Items.Add("5602");
            ddlDriveInLocation.Items.Add("5603");
            ddlDriveInLocation.Items.Add("5604");
            ddlDriveInLocation.Items.Add("5605");
            ddlDriveInLocation.Items.Add("5606");
            ddlDriveInLocation.Items.Add("5607");
            ddlDriveInLocation.Items.Add("5701");
            ddlDriveInLocation.Items.Add("5702");
            ddlDriveInLocation.Items.Add("5703");
            ddlDriveInLocation.Items.Add("5704");
            ddlDriveInLocation.Items.Add("5705");
            ddlDriveInLocation.Items.Add("5706");
            ddlDriveInLocation.Items.Add("5707");
            ddlDriveInLocation.Items.Add("5708");
            ddlDriveInLocation.Items.Add("5801");
            ddlDriveInLocation.Items.Add("5802");
            ddlDriveInLocation.Items.Add("5803");
            ddlDriveInLocation.Items.Add("5804");
            ddlDriveInLocation.Items.Add("5805");
            ddlDriveInLocation.Items.Add("6101");
            ddlDriveInLocation.Items.Add("6102");
            ddlDriveInLocation.Items.Add("6201");
            ddlDriveInLocation.Items.Add("6202");
            ddlDriveInLocation.Items.Add("6301");
            ddlDriveInLocation.Items.Add("6302");
            ddlDriveInLocation.Items.Add("6303");
            ddlDriveInLocation.Items.Add("6304");
            ddlDriveInLocation.Items.Add("6401");
            ddlDriveInLocation.Items.Add("6402");
            ddlDriveInLocation.Items.Add("6403");
            ddlDriveInLocation.Items.Add("6404");
            ddlDriveInLocation.Items.Add("7401");
            ddlDriveInLocation.Items.Add("7402");
            ddlDriveInLocation.Items.Add("7403");
            ddlDriveInLocation.Items.Add("7501");
            ddlDriveInLocation.Items.Add("7502");
            ddlDriveInLocation.Items.Add("7503");
            ddlDriveInLocation.Items.Add("7504");
            ddlDriveInLocation.Items.Add("7601");
            ddlDriveInLocation.Items.Add("7602");
            ddlDriveInLocation.Items.Add("7603");
            ddlDriveInLocation.Items.Add("7604");
            ddlDriveInLocation.Items.Add("7605");
            ddlDriveInLocation.Items.Add("7701");
            ddlDriveInLocation.Items.Add("7702");
            ddlDriveInLocation.Items.Add("7703");
            ddlDriveInLocation.Items.Add("7704");
            ddlDriveInLocation.Items.Add("7705");
            #endregion

            #region
            //put items in dropdownlist for each rails 1
            ddlStatusTrack.Items.Add("1201");
            ddlStatusTrack.Items.Add("1301");
            ddlStatusTrack.Items.Add("1401");
            ddlStatusTrack.Items.Add("1501");
            ddlStatusTrack.Items.Add("1601");
            ddlStatusTrack.Items.Add("1701");
            ddlStatusTrack.Items.Add("1801");
            ddlStatusTrack.Items.Add("1901");
            ddlStatusTrack.Items.Add("2001");
            ddlStatusTrack.Items.Add("2101");
            ddlStatusTrack.Items.Add("3001");
            ddlStatusTrack.Items.Add("3002");
            ddlStatusTrack.Items.Add("3003");
            ddlStatusTrack.Items.Add("3101");
            ddlStatusTrack.Items.Add("3102");
            ddlStatusTrack.Items.Add("3103");
            ddlStatusTrack.Items.Add("3201");
            ddlStatusTrack.Items.Add("3202");
            ddlStatusTrack.Items.Add("3203");
            ddlStatusTrack.Items.Add("3301");
            ddlStatusTrack.Items.Add("3302");
            ddlStatusTrack.Items.Add("3303");
            ddlStatusTrack.Items.Add("3304");
            ddlStatusTrack.Items.Add("3401");
            ddlStatusTrack.Items.Add("3402");
            ddlStatusTrack.Items.Add("3403");
            ddlStatusTrack.Items.Add("3404");
            ddlStatusTrack.Items.Add("3501");
            ddlStatusTrack.Items.Add("3502");
            ddlStatusTrack.Items.Add("3503");
            ddlStatusTrack.Items.Add("3504");
            ddlStatusTrack.Items.Add("3601");
            ddlStatusTrack.Items.Add("3602");
            ddlStatusTrack.Items.Add("3603");
            ddlStatusTrack.Items.Add("3604");
            ddlStatusTrack.Items.Add("3701");
            ddlStatusTrack.Items.Add("3702");
            ddlStatusTrack.Items.Add("3703");
            ddlStatusTrack.Items.Add("3704");
            ddlStatusTrack.Items.Add("3801");
            ddlStatusTrack.Items.Add("3802");
            ddlStatusTrack.Items.Add("3803");
            ddlStatusTrack.Items.Add("3804");
            ddlStatusTrack.Items.Add("4001");
            ddlStatusTrack.Items.Add("4002");
            ddlStatusTrack.Items.Add("4003");
            ddlStatusTrack.Items.Add("4004");
            ddlStatusTrack.Items.Add("4005");
            ddlStatusTrack.Items.Add("4006");
            ddlStatusTrack.Items.Add("4007");
            ddlStatusTrack.Items.Add("4101");
            ddlStatusTrack.Items.Add("4102");
            ddlStatusTrack.Items.Add("4103");
            ddlStatusTrack.Items.Add("4104");
            ddlStatusTrack.Items.Add("4201");
            ddlStatusTrack.Items.Add("4202");
            ddlStatusTrack.Items.Add("4203");
            ddlStatusTrack.Items.Add("4204");
            ddlStatusTrack.Items.Add("4301");
            ddlStatusTrack.Items.Add("4302");
            ddlStatusTrack.Items.Add("4303");
            ddlStatusTrack.Items.Add("4304");
            ddlStatusTrack.Items.Add("4401");
            ddlStatusTrack.Items.Add("4402");
            ddlStatusTrack.Items.Add("4403");
            ddlStatusTrack.Items.Add("4404");
            ddlStatusTrack.Items.Add("4501");
            ddlStatusTrack.Items.Add("4502");
            ddlStatusTrack.Items.Add("4503");
            ddlStatusTrack.Items.Add("4504");
            ddlStatusTrack.Items.Add("4505");
            ddlStatusTrack.Items.Add("4506");
            ddlStatusTrack.Items.Add("4507");
            ddlStatusTrack.Items.Add("4508");
            ddlStatusTrack.Items.Add("4509");
            ddlStatusTrack.Items.Add("5101");
            ddlStatusTrack.Items.Add("5102");
            ddlStatusTrack.Items.Add("5103");
            ddlStatusTrack.Items.Add("5104");
            ddlStatusTrack.Items.Add("5105");
            ddlStatusTrack.Items.Add("5201");
            ddlStatusTrack.Items.Add("5202");
            ddlStatusTrack.Items.Add("5203");
            ddlStatusTrack.Items.Add("5204");
            ddlStatusTrack.Items.Add("5205");
            ddlStatusTrack.Items.Add("5206");
            ddlStatusTrack.Items.Add("5301");
            ddlStatusTrack.Items.Add("5302");
            ddlStatusTrack.Items.Add("5303");
            ddlStatusTrack.Items.Add("5304");
            ddlStatusTrack.Items.Add("5305");
            ddlStatusTrack.Items.Add("5306");
            ddlStatusTrack.Items.Add("5401");
            ddlStatusTrack.Items.Add("5402");
            ddlStatusTrack.Items.Add("5403");
            ddlStatusTrack.Items.Add("5404");
            ddlStatusTrack.Items.Add("5405");
            ddlStatusTrack.Items.Add("5406");
            ddlStatusTrack.Items.Add("5407");
            ddlStatusTrack.Items.Add("5501");
            ddlStatusTrack.Items.Add("5502");
            ddlStatusTrack.Items.Add("5503");
            ddlStatusTrack.Items.Add("5504");
            ddlStatusTrack.Items.Add("5505");
            ddlStatusTrack.Items.Add("5506");
            ddlStatusTrack.Items.Add("5507");
            ddlStatusTrack.Items.Add("5601");
            ddlStatusTrack.Items.Add("5602");
            ddlStatusTrack.Items.Add("5603");
            ddlStatusTrack.Items.Add("5604");
            ddlStatusTrack.Items.Add("5605");
            ddlStatusTrack.Items.Add("5606");
            ddlStatusTrack.Items.Add("5607");
            ddlStatusTrack.Items.Add("5701");
            ddlStatusTrack.Items.Add("5702");
            ddlStatusTrack.Items.Add("5703");
            ddlStatusTrack.Items.Add("5704");
            ddlStatusTrack.Items.Add("5705");
            ddlStatusTrack.Items.Add("5706");
            ddlStatusTrack.Items.Add("5707");
            ddlStatusTrack.Items.Add("5708");
            ddlStatusTrack.Items.Add("5801");
            ddlStatusTrack.Items.Add("5802");
            ddlStatusTrack.Items.Add("5803");
            ddlStatusTrack.Items.Add("5804");
            ddlStatusTrack.Items.Add("5805");
            ddlStatusTrack.Items.Add("6101");
            ddlStatusTrack.Items.Add("6102");
            ddlStatusTrack.Items.Add("6201");
            ddlStatusTrack.Items.Add("6202");
            ddlStatusTrack.Items.Add("6301");
            ddlStatusTrack.Items.Add("6302");
            ddlStatusTrack.Items.Add("6303");
            ddlStatusTrack.Items.Add("6304");
            ddlStatusTrack.Items.Add("6401");
            ddlStatusTrack.Items.Add("6402");
            ddlStatusTrack.Items.Add("6403");
            ddlStatusTrack.Items.Add("6404");
            ddlStatusTrack.Items.Add("7401");
            ddlStatusTrack.Items.Add("7402");
            ddlStatusTrack.Items.Add("7403");
            ddlStatusTrack.Items.Add("7501");
            ddlStatusTrack.Items.Add("7502");
            ddlStatusTrack.Items.Add("7503");
            ddlStatusTrack.Items.Add("7504");
            ddlStatusTrack.Items.Add("7601");
            ddlStatusTrack.Items.Add("7602");
            ddlStatusTrack.Items.Add("7603");
            ddlStatusTrack.Items.Add("7604");
            ddlStatusTrack.Items.Add("7605");
            ddlStatusTrack.Items.Add("7701");
            ddlStatusTrack.Items.Add("7702");
            ddlStatusTrack.Items.Add("7703");
            ddlStatusTrack.Items.Add("7704");
            ddlStatusTrack.Items.Add("7705");
            #endregion

            if (!IsPostBack)
            {
                refreshGUI();
            }
        }

        /// <summary>
        /// Deletes the selected tram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDetailsRemove_Click(object sender, EventArgs e)
        {
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1, "Combino"), new User(2323, "test", "test", 1), 1, true);
            if (tbDetailsName.Text != "")
            {
                //tramname needs to be a number
                bool result = Int32.TryParse(tbDetailsName.Text, out number);
                if (result)
                {
                    //delete the tram 
                    if (tram.DeleteTram(Convert.ToInt32(tbDetailsName.Text)) == true)
                    {
                        //refresh the GUI
                        refreshGUI();
                        return;
                    }
                    //error messages
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Kan tram niet verwijderen');", true);
                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kan tram niet verwijderen')",true);
                }
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Voer een nummer in');", true);
               // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Voer een nummer in')", true);
            }
            ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Geef tramnummer mee');", true);
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Geef tramnummer mee')", true);
        }

        /// <summary>
        /// Edit a tram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDetailsEdit_Click(object sender, EventArgs e)
        {
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1, "Combino"), new User(2323, "test", "test", 1), 1, true);
            int status = 0;
            switch (ddlDetailsStatus.SelectedItem.Text) //check the tram status
            {
                case "Ok":
                    status = 1;
                    break;
                case "Vies":
                    status = 2;
                    break;
                case "Defect":
                    status = 3;
                    break;
                case "Vies en Defect":
                    status = 4;
                    break;
            }

            if (tbDetailsName.Text != "")   //tram name cannot be empty
            {
                bool result = Int32.TryParse(tbDetailsName.Text, out number); //tram name needs to be a number
                if (result)
                {
                    //edit the tram
                    if (
                        tram.MoveTram(Convert.ToInt32(tbDetailsName.Text),
                            Convert.ToInt32(ddlDetailsLocation.SelectedItem.Text), status))
                    {
                        refreshGUI();   //refresh the GUI
                        return;
                    }
                    //error messages
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Kan tram niet aanpassen');", true);
                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kan tram niet aanpassen')", true);
                }
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Voer een nummer in');", true);
                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Voer een nummer in')", true);
            }
            ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Geef tramnummer mee');", true);
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Geef tramnummer mee')", true);
        }

        /// <summary>
        /// create a new tram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddSubmit_Click(object sender, EventArgs e)
        {

            int tramOnRail = 0;
            int status = 0;
            switch (ddlAddStatus.SelectedItem.Text) //get tram status
            {
                case "Ok":
                    status = 1;
                    break;
                case "Vies":
                    status = 2;
                    break;
                case "Defect":
                    status = 3;
                    break;
                case "Vies en Defect":
                    status = 4;
                    break;
            }

            if (cbAddOnTrack.Checked)
            {
                tramOnRail = 1;
            }
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1, "Combino"), new User(2323, "test", "test", 1), 1, true);
            if (tbAddName.Text != "")   //tram name cannot be emtpy
            {
                bool result = Int32.TryParse(tbAddName.Text, out number);
                if (result)
                {
                    //if there is already a tram on this rail, give message
                    ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("MainContent");
                    Label tlbl = (Label)cph.FindControl("rail" + ddlAddLocation.Text);
                    if (tlbl.BackColor != Color.DimGray)
                    {
                        //add the tram
                        if (
                                tram.AddTram(Convert.ToInt32(tbAddName.Text),
                                    Convert.ToInt32(ddlAddLocation.SelectedItem.Text),
                                status,
                                tramOnRail))
                        {
                            tram.Rail.Taken = true;
                            refreshGUI();   //refresh the GUI
                            return;
                        }
                        //error messages
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Kan tram niet toevoegen');", true);
                        //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Kan tram niet toevoegen')", true);
                    }
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Er staat al een tram op dit spoor');", true);
                    //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Er staat al een tram op dit spoor')", true);
                }
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Voer een nummer in');", true);
                //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Voer een nummer in')", true);
            }
            ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Geef tramnummer mee');", true);
            //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Geef tramnummer mee')", true);
        }

        /// <summary>
        /// blocks or unblocks a rail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnStatus_Click(object sender, EventArgs e)
        {
            Rail rail = new Rail(Convert.ToInt32(ddlStatusTrack.SelectedItem.Text), false, false, 1, "Combino");
            if (ddlStatusStatus.SelectedItem.Text == "Blokkeer")
            {
                //if rail is already blocked, go to else
                if (!rail.IsRailBlocked(Convert.ToInt32(ddlStatusTrack.SelectedItem.Text)))
                {
                    //blocks the rail
                    if (rail.BlockRail(Convert.ToInt32(ddlStatusTrack.SelectedItem.Text), 1))
                    {
                        refreshGUI(); //refresh GUI
                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Spoor is al geblokkeerd');", true);
                        //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Spoor is al geblokkeerd')", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Spoor is al geblokkeerd');", true);
                    //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Spoor is al geblokkeerd')", true);
                }
            }
            else if (ddlStatusStatus.SelectedItem.Text == "Deblokkeer")
            {
                //check if rail is already unblocked
                if (rail.IsRailBlocked(Convert.ToInt32(ddlStatusTrack.SelectedItem.Text)))
                {
                    //unblock rail
                    if (rail.BlockRail(Convert.ToInt32(ddlStatusTrack.SelectedItem.Text), 0))
                    {
                        refreshGUI();   //refresh GUI
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Spoor is al gedeblokkeerd');", true);
                        //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Spoor is al gedeblokkeerd')", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Spoor is al gedeblokkeerd');", true);
                    //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Spoor is al gedeblokkeerd')", true);
                }
            }
            refreshGUI();
        }

        /// <summary>
        /// Update Tram and Rail list
        /// </summary>
        private void updateListsFromDB()
        {
            try
            {
                Login.administration.UpdateTramList();
                Login.administration.UpdateRailList();
            }
            catch (NullReferenceException)
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Je moet inloggen om hier gebruik van te maken!!')", true);
            }
        }


        /// <summary>
        /// Refresh the gui to have the trams on the right location
        /// </summary>
        private void refreshGUI()
        {
            updateListsFromDB();
            List<Tram> tramList = Administration.GetTramList;

            // Clear all the labels
            clearGUI();

            if (tramList != null)
            {
                // Check for every tram if they are on a rails
                // if they are, colour the corespondig rectangle 
                // grey and put the id in the rectangle
                foreach (Tram t in tramList)
                {
                    if (t.OnRail)
                    {
                        Rail rail = t.Rail;
                        fillRailLbl(rail.Id, t.Id.ToString(), Color.DimGray);
                    }
                }
            }
        }

        /// <summary>
        /// Clear all the labels in the gui and color labels if they are blocked
        /// </summary>
        private void clearGUI()
        {
            updateListsFromDB();
            List<Rail> railList = Administration.GetRailList;

                if (railList != null)
                {
                    foreach (Rail r in railList)
                    {
                        if (!r.IsRailBlocked(r.Id))
                        {
                            fillRailLbl(r.Id, "", Color.Transparent);
                        }
                        else
                        {
                            fillRailLbl(r.Id, "X", Color.Red);
                        }
                    }
                }
                UpdatePanel1.Update();
            }

        /// <summary>
        /// Colour and fill the label with a string, the label represents the rail 
        /// and string specifies what tram is on the rail.
        /// </summary>
        /// <param name="railID">The id of the rail which the label represents</param>
        /// <param name="lblContent">The string you want to put into that label</param>
        /// <param name="color">The color you want to give the label</param>
        private void fillRailLbl(int railID, string lblContent, Color color)
        {
            ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("MainContent");
            Label tlbl = (Label)cph.FindControl("rail" + railID);
            if (tlbl != null)
            {
                tlbl.Text = lblContent;
                tlbl.BackColor = color;
            }
        }
        protected void btnDriveInAssign_Click(object sender, EventArgs e)
        {
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1, "Combino"), new User(2323, "test", "test", 1), 1, true);
            if (lboxDriveInList.SelectedItem != null)
            {
                //updates the tram
                if (tram.MoveTram(Convert.ToInt32(lboxDriveInList.SelectedItem.Text),
                    Convert.ToInt32(ddlDriveInLocation.SelectedItem.Text), 1))
                {
                    refreshGUI();   //refresh GUI
                    return;
                }
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Kan tram niet verplaatsen');", true);
                //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Kan tram niet verplaatsen')", true);
            }
            ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Geen tram geselecteerd');", true);
            //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Geen tram geselecteerd')", true);
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGUI();
        }



        /// <summary>
        /// Starts or stops the simulation depending on whether the simulation already started
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Simulatie_Click(object sender, EventArgs e)
        {
            if (!Timer1.Enabled)
            {
                startSimulation();
            }
            else
            {
                stopSimulation();
            }
        }

        /// <summary>
        /// Timer tick that does one step of the simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            simulationStep();
        }

        private void simulationStep()
        {
            List<Tram> trList = Administration.GetTramList;
            if (index <= trList.Count)
            {
                Tram tram = trList[index];
                index++;
                Session["index"] = index;
                inuitrij.Assign(tram);

            }
            else
            {
                stopSimulation();
            }

            refreshGUI();
        }
        /// <summary>
        /// Starts the simulation will make trams enter the remise per timer tick
        /// </summary>
        private void startSimulation()
        {
            // Set index to zero
            index = 0;
            Session["index"] = index;
            // Change the text on the button to match the functionality of that button when pressed
            Simulatie.Text = "Stop Simulatie";
            // Enables the Timer
            Timer1.Enabled = true;
            simulationStep();
        }

        /// <summary>
        /// Stops the simulation
        /// </summary>
        private void stopSimulation()
        {
            // Disable the Timer
            Timer1.Enabled = false;

            // Change the text on the button to match the functionality of that button when pressed
            Simulatie.Text = "Simuleer!";
            //simulatielbl.Text = "";
        }

        protected void Uitrijden_Click(object sender, EventArgs e)
        {
            if (padatabase.Clearremise())
            {
                administration.UpdateTramList();    //update tram list
                refreshGUI();   //refresh GUI
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('er is iets fout gegaan! probeer het opnieuw!')", true);
            }

        }
    }
}