using Microsoft.Exchange.WebServices.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EWSMoveMails
{


    public partial class FormMain : Form
    {
        static ExchangeService service;
        static string logFilePath = string.Empty;
        static string csvFilePath = string.Empty;
        static string mailbox = "";
       

        public FormMain()
        {
            InitializeComponent();


        }

        private void rdb_EnvOnprem_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void FormMain_Load(object sender, EventArgs e)
        {



            //txt_OnpremEWSUrl.Text = "https://<yourdomain>/EWS/Exchange.asmx";


            txt_OnpremDomain.Text = "ex16";
            txt_OnpremUser.Text = "Admin001";
            txt_OnpremPwd.Text = "Password1!";
            txt_OnpremEWSUrl.Text = "https://Ex16aio.ex16.com/EWS/Exchange.asmx";

            txt_ImpersonatedUserSMTP.Text = "u001@ex16.com";

            pb_Progress.Visible = false;
            lbl_Progress.Visible = false;
            HideAlert();




        }
        private void HideAlert()
        {
            lbl_AlertMailbox.Visible = false;

        }
        private void rdb_EnvO365_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            

           
            

            HideAlert();

            if (!ValidateValue())
            {
                MessageBox.Show("Please input the required field.");
                return;
            }

            pb_Progress.Visible = true;
            lbl_Progress.Visible = true;
            pb_Progress.Value = 0;
            lbl_Progress.Text = "0%";


            MoveMessage(new FolderId(dgv_SourceFolder.SelectedRows[0].Cells["FolderId"].Value.ToString()), new FolderId(dgv_TargetFolder.SelectedRows[0].Cells["FolderIdColumn"].Value.ToString()));


            //service.TraceEnabled = true;
            //service.TraceFlags = TraceFlags.All;





        }





        private bool ValidateValue()
        {
            bool validatePass = true;


            return validatePass;

        }
        private void MoveMessage(FolderId sourceFolderId, FolderId targetFolderId)
        {
            pb_Progress.Visible = true;
            lbl_Progress.Visible = true;

            int totalMoved = 0;

            ItemView view = new ItemView(20);


            Folder sourceFolder = Folder.Bind(service, sourceFolderId);
            
          

            // Item searches do not support Deep traversal.
            view.Traversal = ItemTraversal.Shallow;
           
            try
            {

                int resultcount = 0;
                do
                {
                    FindItemsResults<Item> results = service.FindItems(sourceFolderId, view);
                    resultcount = results.Count();
                    List<ItemId> itemIdList = new List<ItemId>();
                    foreach (Item item in results.Items)
                    {

                        //EmailMessage message = item as EmailMessage;
                        itemIdList.Add(item.Id);
                      
                        //AddRecord(mailbox, item.Subject, item.DateTimeReceived.ToString(), item.DisplayTo, item.DisplayCc);




                    }
                    if(resultcount > 0)
                    service.MoveItems(itemIdList, targetFolderId);
                    totalMoved += resultcount;
                    itemIdList = null;

                     double progress = ((double)(totalMoved) / (double)sourceFolder.TotalCount) * 100;

                     pb_Progress.Value = (int)progress;
                     lbl_Progress.Text = Math.Round(progress, 0).ToString() + "%";

                } while (resultcount > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("---Exception while enumerating results: {0}", ex.Message);
            }
        }

        private void GenerateServiceForOnpremEnv()
        {
            service = new ExchangeService(ExchangeVersion.Exchange2013);
            if (txt_OnpremUser.Text.Contains("@"))
            {
                service.Credentials = new WebCredentials(txt_OnpremUser.Text.Trim(), txt_OnpremPwd.Text.Trim());

            }
            else
            {
                service.Credentials = new WebCredentials(txt_OnpremUser.Text.Trim(), txt_OnpremPwd.Text.Trim(), txt_OnpremDomain.Text.Trim());

            }
            service.Url = new Uri(txt_OnpremEWSUrl.Text.Trim());

            service.Timeout = 900000;

            System.Net.ServicePointManager.ServerCertificateValidationCallback = (sender1, certificate, chain, sslPolicyErrors) => true;

        }


        private void WriteLog(string loginfo)
        {
            File.AppendAllText(logFilePath, loginfo);
            File.AppendAllText(logFilePath, "\r\n");
        }


        private void AddRecord(string Mailbox, string Subject, string Date, string ToRecipient, string CcRecipient)
        {
            try
            {

                File.AppendAllText(csvFilePath, Mailbox + "," + Subject + "," + Date + "," + ToRecipient + "," + CcRecipient);
                File.AppendAllText(csvFilePath, "\r\n");
                WriteLog(Mailbox + "," + Subject + "," + Date + "," + ToRecipient + "," + CcRecipient);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program did an oopsie :", ex);
            }
        }




        private void btn_Connect_Click(object sender, EventArgs e)
        {

            GenerateServiceForOnpremEnv();
            service.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, txt_ImpersonatedUserSMTP.Text.Trim());

            // Create a view with a page size of 2000.
            FolderView view = new FolderView(2000);

            // Identify the properties to return in the results set.
            view.PropertySet = new PropertySet(BasePropertySet.IdOnly);
            view.PropertySet.Add(FolderSchema.DisplayName);



            // Unlike FindItem searches, folder searches can be deep traversals.
            view.Traversal = FolderTraversal.Deep;
            FindFoldersResults findFolderResults = service.FindFolders(WellKnownFolderName.MsgFolderRoot, view);

            FolderDS sourcefolderDataSet = new FolderDS();
            FolderDS targetfolderDataSet = new FolderDS();
            foreach (Folder myFolder in findFolderResults.Folders)
            {

                myFolder.Load();
                int count = myFolder.TotalCount;
                sourcefolderDataSet.FolderDT.AddFolderDTRow(myFolder.DisplayName, myFolder.Id.UniqueId, count.ToString());
                targetfolderDataSet.FolderDT.AddFolderDTRow(myFolder.DisplayName, myFolder.Id.UniqueId, count.ToString());


            }

            dgv_SourceFolder.DataSource = sourcefolderDataSet.FolderDT;

            dgv_TargetFolder.DataSource = targetfolderDataSet.FolderDT;

        }
        class UserSettings
        {
            public string env;
            public string domain;
            public string user;
            public string pwd;
            public string ewsUrl;
            public string tenantId;
            public string applicationId;
            public string secret;
            public string start;
            public string end;
            public string keywordType;
            public string messageId;
            public string subject;
            public string Mailboxlist;
            public string calculateonly;

        }

        class GlobalVar
        {
            public string adTenant = "";
            public string clientId = "";
            public string secret = "";
            public string tokenAuthority;
            public string body;
            public string resource = "https://outlook.office365.com/";
            public GlobalVar(string tenantId, string applicationId, string clientSecret)
            {
                adTenant = tenantId;
                clientId = applicationId;
                secret = clientSecret;
                string secret_encoded = HttpUtility.UrlEncode(secret);
                tokenAuthority = "https://login.windows.net/" + adTenant + "/oauth2/token";
                body = "resource=" + resource + "&client_id=" + clientId + "&client_secret=" + secret_encoded + "&grant_type=client_credentials";
            }

            public string RequestToken()
            {
                HttpContent content = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");


                HttpClient httpClient = new HttpClient();

                var response = httpClient.PostAsync(tokenAuthority, content).Result;

                var contents = response.Content.ReadAsStringAsync().Result;

                TokenResult tokenResult = JsonConvert.DeserializeObject<TokenResult>(contents);

                token = tokenResult.access_token;
                return token;
            }




            //public static string tokenAuthority = "https://login.microsoftonline.com/" + adTenant + "/oauth2/v2.0/token";



            public string token = string.Empty;
        }

        public class TokenResult
        {
            public string token_type;
            public string scope;
            public string expires_in;
            public string ext_expires_in;
            public string expires_on;
            public string not_before;
            public string resource;
            public string access_token;
            public string refresh_token;
            public string id_token;


        }



    }
}
