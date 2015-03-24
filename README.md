# Rest Api Generator
Rest Api generator, to create the api files for any jsonObject in inputs.
You can clone the repo through https://github.com/HusseinTaha/RestApi-Generator.git

# Use
Just run the project in visual studio 2013.
When running, please chose the root model name, and the project name that you want to add the files to it.
Finally add the jsonObject, not an Array.
And will create the files for you.

# Important
When you finish generating files, use the Package Manager Console in visual studio in your Api project and install the following:
  ```Update-Package Microsoft.AspNet.WebApi.WebHost -Pre```<br />
  ```Install-Package Microsoft.AspNet.WebApi.Cors```
  
Don't forget to add this line to your Application_Start method in Global.asax file: ```WebApiConfig.Register(GlobalConfiguration.Configuration);```
  
# Contribution
Please if you want to edit, or update and make the project better, please don't hesitate, and make a pull request ;)
