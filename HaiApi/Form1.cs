using HaiApi.DTO;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using System.Configuration;

namespace HaiApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-UU8ITLT;Database=HAITest;Integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        
        private async void BtnGet_Click(object sender, EventArgs e)
        {
            if (TxtURL.Text != "")
            {
                try
                {
                    var client = new HttpClient();
                    var endpoint = new Uri(TxtURL.Text);
                    var result = await client.GetAsync(endpoint);
                    var json = await result.Content.ReadAsStringAsync();
                    //var postList = JsonConvert.DeserializeObject<List<PostResultDto>>(json);
                    TxtJson.Text = json;
                    TxtConc.Text = "Response = 200 OK";
                }
                catch (Exception)
                {
                    TxtConc.Text = "{ Response = 400 Error }";
                    throw;
                }

            }
            else
            {
                TxtConc.Text = "{ Response = 400 Error ErrorCode = URL Giriniz }";
            }
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            if (TxtURL.Text != null)
            {
                using var client = new HttpClient();
                string requestAddress = TxtURL.Text;
                string jsonBody = TxtJson.Text;
                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(requestAddress, content);
                var resMessage = await response.Content.ReadAsStringAsync();
                TxtConc.Text = resMessage;

                //GoodsIN goods = new GoodsIN();

                //try
                //{
                //    GoodsIN goodsIn = JsonConvert.DeserializeObject<GoodsIN>(jsonBody);
                //}
                //catch (Exception ex)
                //{

                //    throw;
                //}

            }
            else
            {
                TxtConc.Text = "{ Response = 400 Error ErrorCode = URL Giriniz }";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtURL.Focus();
            TxtConc.Text = "URL Giriniz.";
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM VTaskCreate", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "VTaskCreate");
            dataGridView1.DataSource = ds.Tables["VTaskCreate"];
            con.Close();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void BtnJson_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void BtnInboundIla_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void BtnOutboundIla_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void BtnInboundCreate_Click(object sender, EventArgs e)
        {
            //GoodsIN goods = Form1.ExecAddGoodsIN(string OrderCode, WorkStationId, out int Id, out int ReturnParam, out string ReturnDescription);

        }

        public static int ExecAddGoodsIN(string OrderCode, int WorkStationId, out int Id, out int ReturnParam, out string ReturnDescription)
        {
            int Sonuc = -10;
            Id = 0;
            ReturnParam = -10;
            ReturnDescription = "";

            SqlConnection con = new SqlConnection(@"Server=DESKTOP-UU8ITLT;Database=HAITest;Integrated security=true");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HAIAddGoodsIn";

            cmd.Parameters.Add("OrderCode ", SqlDbType.NVarChar, 50).Value = OrderCode;

            cmd.Parameters.Add("WorkStationId", SqlDbType.Int).Value = WorkStationId;

            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters["@Id"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@ReturnParam", SqlDbType.Int);
            cmd.Parameters["@ReturnParam"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@ReturnDescription", SqlDbType.NVarChar);
            cmd.Parameters["@ReturnDescription"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            Sonuc = Convert.ToInt32(cmd.Parameters["@return_value"].Value);
            Id = Convert.ToInt32(cmd.Parameters["@Id"].Value);
            ReturnParam = Convert.ToInt32(cmd.Parameters["@ReturnParam"].Value);
            ReturnDescription = cmd.Parameters["@ReturnDescription"].Value.ToString();

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Sonuc = Convert.ToInt32(cmd.Parameters["@return_value"].Value);
                Id = Convert.ToInt32(cmd.Parameters["@Id"].Value);
                ReturnParam = Convert.ToInt32(cmd.Parameters["@ReturnParam"].Value);
                ReturnDescription = cmd.Parameters["@ReturnDescription"].Value.ToString();
                return Sonuc;
            }
            catch (Exception ex)
            {
                ReturnDescription = cmd.Parameters["@ReturnDescription"].Value.ToString();
                return Sonuc;
                throw;
            }
            finally { con.Close(); }
        }
    }
}