using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace Lab4_23520231_23520249
{
    public partial class Lab4_BaiTap3 : Form
    {
        public Lab4_BaiTap3()
        {
            InitializeComponent();
            InitializeListCityComboBox();
        }
        private void InitializeListCityComboBox()
        {
            // Gắn danh sách thành phố vào ComboBox
            cbx_CityList.DataSource = new BindingSource(CityList, null);
            cbx_CityList.DisplayMember = "Key"; // Hiển thị tên thành phố
            cbx_CityList.ValueMember = "Value"; // Gắn giá trị là tọa độ
            // Gắn giá trị trực tiếp vào tbx
            tb_Kinh.DataBindings.Add("Text", cbx_CityList.DataSource, "Value.Item2", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_Vi.DataBindings.Add("Text", cbx_CityList.DataSource, "Value.Item1", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        public async Task<WeatherInfo[]> GetWeatherAsync(string latitude, string longitude)
        {
            //URL của Open-Meteo API với tham số vĩ độ, kinh độ và các loại thông tin thời tiết trong 3 ngày 
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,relative_humidity_2m,windspeed_10m,pressure_msl&timezone=Asia%2FBangkok&forecast_days=3";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);//Gửi yêu cầu và đợi phản hồi
                if (response.IsSuccessStatusCode)//Kiểm tra nếu yêu cầu thành công (mã trạng thái 200)
                {
                    string data = await response.Content.ReadAsStringAsync();//Đọc thông tin phản hồi
                    var result = JsonConvert.DeserializeObject<dynamic>(data);//Chuyển kết quả thành đối tượng dạng động

                    // Truy xuất dữ liệu thời tiết từ kết quả
                    var temperatureData = result.hourly.temperature_2m;//Nhiệt độ
                    var humidityData = result.hourly.relative_humidity_2m;//Độ ẩm chung
                    var windspeedData = result.hourly.windspeed_10m;//Tốc độ gió
                    var pressureData = result.hourly.pressure_msl;//Áp suất

                    var weatherInfoList = new WeatherInfo[temperatureData.Count];//Tạo danh sách lưu dữ liệu

                    for (int i = 0; i < temperatureData.Count; i++)//Lưu dữ liệu vào danh sách
                    {
                        weatherInfoList[i] = new WeatherInfo
                        {
                            time = result.hourly.time[i],
                            temperature_2m = temperatureData[i],
                            relative_humidity_2m = humidityData[i],
                            windspeed_10m = windspeedData[i],
                            pressure_msl = pressureData[i]
                        };
                    }
                    return weatherInfoList;//Trả danh sách dữ liệu
                }
                else
                {
                    throw new Exception("Lỗi! không thu thập được dữ liệu.");
                }
            }
        }
        private Dictionary<string, Tuple<string, string>> CityList = new Dictionary<string, Tuple<string, string>>()
        {
            { "Biên Hoà, Đồng Nai", Tuple.Create("10.8638914", "106.6873414") },
            { "Tp. Bảo Lộc, Lâm Đồng", Tuple.Create("11.5481785", "107.7137872") },
            { "Hà Nội, Hà Nội", Tuple.Create("21.0285", "105.8542") },
            { "TP. Hồ Chí Minh, TP. Hồ Chí Minh", Tuple.Create("10.8231", "106.6297") },
            { "Đà Nẵng, Đà Nẵng", Tuple.Create("16.0471", "108.2068") },
            { "Hải Phòng, Hải Phòng", Tuple.Create("20.8449", "106.6881") },
            { "Cần Thơ, Cần Thơ", Tuple.Create("10.0452", "105.7469") },
            { "Huế, Thừa Thiên - Huế", Tuple.Create("16.4637", "107.5909") },
            { "Nha Trang, Khánh Hòa", Tuple.Create("12.2388", "109.1967") },
            { "Vũng Tàu, Bà Rịa - Vũng Tàu", Tuple.Create("10.4114", "107.1362") },
            { "Quy Nhơn, Bình Định", Tuple.Create("13.7820", "109.2193") },
            { "Đà Lạt, Lâm Đồng", Tuple.Create("11.9404", "108.4583") },
            { "Buôn Ma Thuột, Đắk Lắk", Tuple.Create("12.6667", "108.0500") },
            { "Thái Nguyên, Thái Nguyên", Tuple.Create("21.5892", "105.8310") },
            { "Nam Định, Nam Định", Tuple.Create("20.4200", "106.1686") },
            { "Thanh Hóa, Thanh Hóa", Tuple.Create("19.8067", "105.7856") },
            { "Vinh, Nghệ An", Tuple.Create("18.6796", "105.6816") },
            { "Phan Thiết, Bình Thuận", Tuple.Create("10.9805", "108.2615") },
            { "Sóc Trăng, Sóc Trăng", Tuple.Create("9.6025", "105.9739") },
            { "Hạ Long, Quảng Ninh", Tuple.Create("20.9101", "107.1839") },
            { "Pleiku, Gia Lai", Tuple.Create("13.9833", "108.0000") },
            { "Long Xuyên, An Giang", Tuple.Create("10.3759", "105.4185") },
            { "Mỹ Tho, Tiền Giang", Tuple.Create("10.3605", "106.3657") },
            { "Rạch Giá, Kiên Giang", Tuple.Create("10.0125", "105.0809") },
            { "Cao Lãnh, Đồng Tháp", Tuple.Create("10.4642", "105.6346") },
            { "Tuy Hòa, Phú Yên", Tuple.Create("13.0956", "109.3209") },
            { "Hà Giang, Hà Giang", Tuple.Create("22.1515", "104.9859") },
            { "Lai Châu, Lai Châu", Tuple.Create("22.3442", "103.8355") },
            { "Lào Cai, Lào Cai", Tuple.Create("22.4300", "103.9991") },
            { "Sơn La, Sơn La", Tuple.Create("21.3201", "103.9005") },
            { "Điện Biên Phủ, Điện Biên", Tuple.Create("21.0401", "103.0207") },
            { "Yên Bái, Yên Bái", Tuple.Create("21.7356", "104.8673") },
            { "Quảng Ngãi, Quảng Ngãi", Tuple.Create("15.1156", "108.8050") },
            { "Kon Tum, Kon Tum", Tuple.Create("13.9797", "108.0049") },
            { "Quảng Trị, Quảng Trị", Tuple.Create("16.7578", "107.1133") },
            { "Bình Thuận, Bình Thuận", Tuple.Create("10.9333", "108.0916") },
            { "Hưng Yên, Hưng Yên", Tuple.Create("20.8092", "106.0637") },
            { "Bạc Liêu, Bạc Liêu", Tuple.Create("9.2900", "105.7153") },
            { "Tuyên Quang, Tuyên Quang", Tuple.Create("21.8312", "105.2234") },
            { "Phú Quốc, Kiên Giang", Tuple.Create("10.2899", "103.9840") },
            { "Vĩnh Yên, Vĩnh Phúc", Tuple.Create("21.3120", "105.5891") },
            { "Móng Cái, Quảng Ninh", Tuple.Create("21.4825", "108.0600") },
            { "Cao Bằng, Cao Bằng", Tuple.Create("22.6656", "106.2443") },
            { "Bắc Giang, Bắc Giang", Tuple.Create("21.2700", "106.1944") },
            { "Hà Tĩnh, Hà Tĩnh", Tuple.Create("18.3383", "105.9069") },
            { "Ninh Bình, Ninh Bình", Tuple.Create("20.2586", "105.9748") },
            { "Quảng Nam, Quảng Nam", Tuple.Create("15.5733", "108.4652") },
            { "Bình Dương, Bình Dương", Tuple.Create("10.9690", "106.6522") },
            { "Bình Phước, Bình Phước", Tuple.Create("11.5019", "106.9492") },
            { "Hòa Bình, Hòa Bình", Tuple.Create("20.8027", "105.3428") }
        };
        private async void cbx_CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy thông tin thành phố được chọn
            var selectedCity = (KeyValuePair<string, Tuple<string, string>>)((BindingSource)cbx_CityList.DataSource).Current;

            // Hiển thị vĩ độ và kinh độ vào các TextBox
            tb_Vi.Text = selectedCity.Value.Item1;  // Vĩ độ
            tb_Kinh.Text = selectedCity.Value.Item2; // Kinh độ
        }
        private async void bt_Load_Click(object sender, EventArgs e)
        {
            string latitude = tb_Vi.Text;   //Nhập vĩ độ
            string longitude = tb_Kinh.Text; //Nhập kinh độ

            try
            {
                var weatherInfoList = await GetWeatherAsync(latitude, longitude);
                GridView_Show.DataSource = weatherInfoList; //Hiển thị dữ liệu trong DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Thông báo lỗi nếu có
            }
        }

        private void Lab4_BaiTap3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
