using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RestApiGenerator
{
    public partial class Main : Form
    {
        private const string modelPath = "/Models";
        private const string controllerPath = "/Controllers";
        private const string configPath = "/App_Start";
        private const string readmePath = "/Readme.txt";
        private string path = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.ActiveControl = modelNameText;  
        }


        private void addCreator(ref StringBuilder sb)
        {
            DateTime time = DateTime.Now; 
            const string format = "MMM ddd d yyyy";  
            sb.AppendLine("/*");
            sb.AppendLine("Created By CoMrEd on : " + time.ToString(format));
            sb.AppendLine("® Copyright 2015 | RestApiGenerator :) ");
            sb.AppendLine("*/");
        }

        private void startModel(ref StringBuilder sb, string projectName, string model)
        {
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("");
            sb.AppendLine(String.Format("namespace {0}.Models", projectName));
            sb.AppendLine("{");
            sb.AppendLine(String.Format("	public class {0}", model));
            sb.AppendLine("	{");
        }

        private void addFunctions(ref StringBuilder sb, string model)
        {
            sb.AppendLine("");
            sb.AppendLine(String.Format("		public static IEnumerable<{0}>  getAll()", model));
            sb.AppendLine("		{");
            sb.AppendLine("			//TODO");
            sb.AppendLine("			throw new NotImplementedException();");
            sb.AppendLine("		}");
            sb.AppendLine("");
            sb.AppendLine(String.Format("		public static {0} get(int id)", model));
            sb.AppendLine("		{");
            sb.AppendLine("			//TODO");
            sb.AppendLine("			throw new NotImplementedException();");
            sb.AppendLine("		}");
            sb.AppendLine("");
            sb.AppendLine(String.Format("		public static int Add({0} val)", model));
            sb.AppendLine("		{");
            sb.AppendLine("			//TODO");
            sb.AppendLine("			throw new NotImplementedException();");
            sb.AppendLine("		}");
            sb.AppendLine("");
            sb.AppendLine(String.Format("		public static void update(int i, {0} val)", model));
            sb.AppendLine("		{");
            sb.AppendLine("			//TODO");
            sb.AppendLine("			throw new NotImplementedException();");
            sb.AppendLine("		}");
            sb.AppendLine("");
            sb.AppendLine("		public static void delete(int i)");
            sb.AppendLine("		{");
            sb.AppendLine("			//TODO");
            sb.AppendLine("			throw new NotImplementedException();");
            sb.AppendLine("		}");
        }

        private void createResponseObject(ref StringBuilder sb, string projectName)
        {
            startModel(ref sb, projectName, "ResponseObject");
            sb.AppendLine("		public Boolean success;");
            sb.AppendLine("		public int error;");
            sb.AppendLine("		public string message;");
            end(ref sb);
        }
        private void createConfigApi(ref StringBuilder sb, string projectName)
        {
            sb.AppendLine("using Newtonsoft.Json.Serialization;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Web;");
            sb.AppendLine("using System.Web.Http;");
            sb.AppendLine("");
            sb.AppendLine(String.Format("namespace {0}.App_Start", projectName));
            sb.AppendLine("{");
            sb.AppendLine("	public static class WebApiConfig");
            sb.AppendLine("	{");

            sb.AppendLine("		public static void Register(HttpConfiguration config)");
            sb.AppendLine("		{");
            sb.AppendLine("			config.Routes.MapHttpRoute(");
            sb.AppendLine("				name: \"DefaultApi\",");
            sb.AppendLine("				routeTemplate: \"api/{controller}/{id}\",");
            sb.AppendLine("				defaults: new { id = RouteParameter.Optional }");
            sb.AppendLine("			);");
            sb.AppendLine("			config.EnableCors();");
            sb.AppendLine("			var json = config.Formatters.JsonFormatter;");
            sb.AppendLine("			json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;");
            sb.AppendLine("			json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();");
            sb.AppendLine("			config.Formatters.Remove(config.Formatters.XmlFormatter);");
            sb.AppendLine("		}");
            end(ref sb);
        }


        private void startController(ref StringBuilder sb, string projectName, string controller)
        {
            sb.AppendLine(String.Format("using {0}.Models;", projectName));
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Diagnostics;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Net;");
            sb.AppendLine("using System.Net.Http;");
            sb.AppendLine("using System.Web.Http;");
            sb.AppendLine("");
            sb.AppendLine(String.Format("namespace {0}.Controllers", projectName));
            sb.AppendLine("{");
            sb.AppendLine(String.Format("	public class {0}Controller : ApiController", controller));
            sb.AppendLine("	{");
        }

        private void createApiMethods(ref StringBuilder sb, string model)
        {
            sb.AppendLine("		// GET api/<controller>");
            sb.AppendLine(String.Format("		public IEnumerable<{0}> Get()", model));
            sb.AppendLine("		{");
            sb.AppendLine(String.Format("			return {0}.getAll();", model));
            sb.AppendLine("		}");

            sb.AppendLine("		// GET api/<controller>/5");
            sb.AppendLine(String.Format("		public {0} Get(int id)", model));
            sb.AppendLine("		{");
            sb.AppendLine(String.Format("			return {0}.get(id);", model));
            sb.AppendLine("			//TOCONTINUE");
            sb.AppendLine("			//ADD TRY CATCH");
            sb.AppendLine("		}");

            sb.AppendLine("		// POST api/<controller>");
            sb.AppendLine(String.Format("		public ResponseObject Post([FromBody]{0} value)", model));
            sb.AppendLine("		{");
            sb.AppendLine(String.Format("			{0}.Add(value);", model));
            sb.AppendLine("			//TOCONTINUE");
            sb.AppendLine("			//ADD TRY CATCH");
            sb.AppendLine("		}");

            sb.AppendLine("		// PUT api/<controller>/5");
            sb.AppendLine(String.Format("		public ResponseObject Put(int id, [FromBody]{0} value)", model));
            sb.AppendLine("		{");
            sb.AppendLine(String.Format("			{0}.update(id, value);", model));
            sb.AppendLine("			//TOCONTINUE");
            sb.AppendLine("			//ADD TRY CATCH");
            sb.AppendLine("		}");

            sb.AppendLine("		// DELETE api/<controller>/5");
            sb.AppendLine("		public ResponseObject Delete(int id)");
            sb.AppendLine("		{");
            sb.AppendLine(String.Format("			{0}.delete(id);", model));
            sb.AppendLine("			//TOCONTINUE");
            sb.AppendLine("			//ADD TRY CATCH");
            sb.AppendLine("		}");
        }

        private void createReadmeFile(ref StringBuilder sb)
        {
            sb.AppendLine("************************************************************************************************");
            sb.AppendLine("*										Important !											   *");
            sb.AppendLine("************************************************************************************************");
            sb.AppendLine("*	Please install the following plugins using Package Manage Console in visual studio :	   *");
            sb.AppendLine("*	--> Update-Package Microsoft.AspNet.WebApi.WebHost -Pre									   *");
            sb.AppendLine("*	--> Install-Package Microsoft.AspNet.WebApi.Cors										   *");
            sb.AppendLine("*	Don't forget to add this line in your Global.asax file, in the method : Application_Start  *");
            sb.AppendLine("*	--> WebApiConfig.Register(GlobalConfiguration.Configuration);							   *");
            sb.AppendLine("************************************************************************************************");
            sb.AppendLine("*										 CoMrEd												   *");
            sb.AppendLine("************************************************************************************************");
        }

        private void end(ref StringBuilder sb)
        {
            sb.AppendLine("	}");
            sb.AppendLine("}");
        }

        private void createVariables(string projectName, dynamic val, ref StringBuilder sb, string name, Newtonsoft.Json.Linq.JTokenType type)
        {
            if (type == Newtonsoft.Json.Linq.JTokenType.Array)
            {
                if (val[0].Value == null)
                {
                    name = Char.ToUpperInvariant(name[0]) + name.Substring(1);
                    sb.AppendLine(String.Format("		public IEnumerable<{0}> {1};", name, Char.ToLowerInvariant(name[0]) + name.Substring(1)));
                    generateCode(val[0], projectName, name);
                }
                else
                {
                    sb.AppendLine(String.Format("		public IEnumerable<{0}> {1};", val[0].Type.ToString(), Char.ToLowerInvariant(name[0]) + name.Substring(1)));
                }
            }
            else if (type == Newtonsoft.Json.Linq.JTokenType.String)
            {
                sb.AppendLine(String.Format("		public string {0};", name));
            }
            else if (type == Newtonsoft.Json.Linq.JTokenType.Boolean)
            {
                sb.AppendLine(String.Format("		public Boolean {0};", name));
            }
            else if (type == Newtonsoft.Json.Linq.JTokenType.Date)
            {
                sb.AppendLine(String.Format("		public DateTime {0};", name));
            }
            else if (type == Newtonsoft.Json.Linq.JTokenType.Float)
            {
                sb.AppendLine(String.Format("		public double {0};", name));
            }
            else if (type == Newtonsoft.Json.Linq.JTokenType.Integer)
            {
                sb.AppendLine(String.Format("		public int {0};", name));
            }
            else if (type == Newtonsoft.Json.Linq.JTokenType.Object)
            {
                name = Char.ToUpperInvariant(name[0]) + name.Substring(1);
                sb.AppendLine(String.Format("		public {0} {1};", name, Char.ToLowerInvariant(name[0]) + name.Substring(1)));
                generateCode(val, projectName, name);
            }
        }

        private void WriteFile(string path, StringBuilder sb)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path))
            {
                file.Write(sb.ToString());
            }
        }

      
        private void generateCode(dynamic jObject, string projectName, string model)
        {
            StringBuilder sbModel = new StringBuilder();
            addCreator(ref sbModel);

            startModel(ref sbModel, projectName, model);
          
            foreach (var item in jObject)
            {
                var name = item.Name;
                var value = item.Value;
                if(value.Type !=null)
                    createVariables(projectName, value, ref sbModel, name, value.Type);
                else
                    createVariables(projectName, value, ref sbModel, name, Newtonsoft.Json.Linq.JTokenType.Object);
            }
            addFunctions(ref sbModel, model);
            end(ref sbModel);

            StringBuilder sbController = new StringBuilder();
            addCreator(ref sbController);
            startController(ref sbController, projectName, model);
            createApiMethods(ref sbController, model);
            end(ref sbController);

            
            WriteFile(String.Format("{0}{1}/{2}.cs", path, modelPath, model), sbModel);
            WriteFile(String.Format("{0}{1}/{2}Controller.cs", path, controllerPath, model), sbController);

            sbController.Clear();
            sbModel.Clear();
        }


        private void generateAll(dynamic jObject, string projectName, string model)
        {
            generateCode(jObject, projectName, model);

            StringBuilder sbResponse = new StringBuilder();
            addCreator(ref sbResponse);
            createResponseObject(ref sbResponse, projectName);

            StringBuilder sbConfigApi = new StringBuilder();
            addCreator(ref sbConfigApi);
            createConfigApi(ref sbConfigApi, projectName);

            StringBuilder sbReadme = new StringBuilder();
            createReadmeFile(ref sbReadme);

            WriteFile(String.Format("{0}{1}", path, readmePath), sbReadme);
            WriteFile(String.Format("{0}{1}/ResponseObject.cs", path, modelPath), sbResponse);
            WriteFile(String.Format("{0}{1}/{2}", path, configPath, "WebApiConfig.cs"), sbConfigApi);

            sbConfigApi.Clear();
            sbResponse.Clear();
            MessageBox.Show("Finished => " + path);
        }


        private void starter(string projectName, string rootModel, string jsonText)
        {
            dynamic jObject = JsonConvert.DeserializeObject(jsonText);
            generateAll(jObject, projectName, rootModel);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (modelNameText.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the root model name!");
                return;
            }
            if (projectNameText.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the  project name!");
                return;
            }

            if (richJsonText.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the json object");
                return;
            }
            
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            folderBrowserDialog1.SelectedPath = directory;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                if (path == null)
                {
                    MessageBox.Show("Error in path!");
                    return;
                }
                
                string rootModel = modelNameText.Text;
                string projectName = projectNameText.Text;
                string jsonText = richJsonText.Text;
                path = String.Format("{0}/{1}", path, projectName);
                projectName = Char.ToUpperInvariant(projectName[0]) + projectName.Substring(1);
                rootModel = Char.ToUpperInvariant(rootModel[0]) + rootModel.Substring(1);

                if (!System.IO.Directory.Exists(path + modelPath))
                {
                    Directory.CreateDirectory(path + modelPath);
                }
                if (!System.IO.Directory.Exists(path + configPath))
                {
                    Directory.CreateDirectory(path + configPath);
                }
                if (!System.IO.Directory.Exists(path + controllerPath))
                {
                    Directory.CreateDirectory(path + controllerPath);
                }
                try
                {
                    ThreadStart threadStart = () => starter(projectName, rootModel, jsonText);
                    Thread thread = new Thread(threadStart);
                    thread.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No valid json inputs! : " + ex.Message);
                }
            }
        }

        private void modelNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                projectNameText.Focus();
            }
        }

        private void projectNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                richJsonText.Focus();
            }
        }

        private void richJsonText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                generate.PerformClick();
            }
        }

      

    }
}
