using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.Remise;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.DataBase;
using System.Drawing;

namespace ICT4RealsWebForms
{
    public partial class About : Page
    {
        TRdatabase tramDatabase = new TRdatabase();
        RAdatabase railDatabase = new RAdatabase();
        int number; //test for tryparse
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDetailsStatus.Items.Clear();
                ddlDetailsStatus.Items.Add("Ok");
                ddlDetailsStatus.Items.Add("Vies");
                ddlDetailsStatus.Items.Add("Defect");
                ddlDetailsStatus.Items.Add("Vies en Defect");
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

        protected void btnDetailsRemove_Click(object sender, EventArgs e)
        {
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1), new User(2323, "test", "test", 1), 1, true);
            if (tbDetailsName.Text != "")
            {
                bool result = Int32.TryParse(tbDetailsName.Text, out number);
                if (result)
                {
                    if (tram.DeleteTram(Convert.ToInt32(tbDetailsName.Text)) == true)
                    {
                        refreshGUI(); //not sure
                        return;
                    }
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kan tram niet verwijderen')",
                        true);
                }
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Voer een nummer in')", true);
            }
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Geef tramnummer mee')", true);
        }

        protected void btnDetailsEdit_Click(object sender, EventArgs e)
        {
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1), new User(2323, "test", "test", 1), 1, true);
            int status = 0;
            switch (ddlDetailsStatus.SelectedItem.Text)
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

            if (tbDetailsName.Text != "")
            {
                bool result = Int32.TryParse(tbDetailsName.Text, out number);
                if (result)
                {
                    if (
                        tram.MoveTram(Convert.ToInt32(tbDetailsName.Text),
                            Convert.ToInt32(ddlDetailsLocation.SelectedItem.Text), status))
                    {
                        refreshGUI(); //not sure
                        return;
                    }                
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kan tram niet aanpassen')", true);
                }
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Voer een nummer in')", true);
            }
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Geef tramnummer mee')", true);
        }

        protected void btnAddSubmit_Click(object sender, EventArgs e)
        {
            
            int tramOnRail = 0;
            int status = 0;
            switch (ddlAddStatus.SelectedItem.Text)
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
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1), new User(2323, "test", "test", 1), 1, true);
            if (tbAddName.Text != "")
            {
                bool result = Int32.TryParse(tbAddName.Text, out number);
                if (result)
                {
                    if (
                        tram.AddTram(Convert.ToInt32(tbAddName.Text), Convert.ToInt32(ddlAddLocation.SelectedItem.Text),
                            status,
                            tramOnRail))
                    {
                        refreshGUI(); //not sure
                        return;
                    }                
                    ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Kan tram niet toevoegen')", true);
                }                    
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Voer een nummer in')", true);
            }
            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Geef tramnummer mee')", true);
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {
            Rail rail = new Rail(Convert.ToInt32(ddlStatusTrack.SelectedItem.Text), false, false, 1);
            if (ddlStatusStatus.SelectedItem.Text == "Blokkeer")
            {
                refreshGUI(); //not sure
            }
            else if (ddlStatusStatus.SelectedItem.Text == "Deblokkeer")
            {
                refreshGUI(); //not sure
            }
            refreshGUI();
        }


        /// <summary>
        /// Refresh the gui to have the trams on the right location
        /// </summary>
        private void refreshGUI()
        {
            try
            {
                Login.administration.UpdateTramList();
            }
            catch (NullReferenceException)
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Je moet inloggen om hier gebruik van te maken!!')", true);
            }
            //List<Tram> trams = Administration.GetTramList;
            /*
            foreach (Control c in groupBox1.Controls)
            {
                if (c.Name.StartsWith("spoor"))
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }

            }
            */
            try
            {
                foreach (Tram t in Administration.GetTramList)
                {
                    if (t.OnRail)
                    {
                        Rail rail = t.Rail;
                        
                        string id = Convert.ToString(rail.Id);
                        ContentPlaceHolder cph = (ContentPlaceHolder) this.Master.FindControl("MainContent");
                        Label tlbl = (Label)cph.FindControl("rail" + id);
                        if (tlbl != null)
                        {
                            tlbl.Text = Convert.ToString(t.Id);
                            tlbl.BackColor = Color.DimGray;
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Geen trams gevonden in de database.')", true);
            }
        }

        protected void btnDriveInAssign_Click(object sender, EventArgs e)
        {
            Tram tram = new Tram(1, "test", new Rail(1, true, false, 1), new User(2323, "test", "test", 1), 1, true);
            if (lboxDriveInList.SelectedItem != null)
            {
                if (tram.MoveTram(Convert.ToInt32(lboxDriveInList.SelectedItem.Text),
                    Convert.ToInt32(ddlDriveInLocation.SelectedItem.Text), 1))
                {
                    refreshGUI(); //not sure
                    return;
                }
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Kan tram niet verplaatsen')", true);
            }
            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Geen tram geselecteerd')", true);
        }
    }
}