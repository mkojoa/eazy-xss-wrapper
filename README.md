# eazy-xss-wrapper
[![made-with-csharp](https://img.shields.io/badge/csharp-1f425f?logo=c#)](https://microsoft.com/csharp)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Eazy xss wrapper help prevents cross-site scripting attacks in .netcore application.

![](https://vistr.dev/badge?repo=mkojoa-eazy-xss-wrapper&color=0058AD)


#### Fuel my efforts with a cup of Coffee.
<a href="https://www.buymeacoffee.com/mkojoa" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height:30px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

## Get Started

#### Installation (Not Yet)
    - Install-Package eazy-xss-wrapper

Add `UseEazyXssWrapper()` to aspnet core middleware pipeline.
```c#
  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEazyXssWrapper(Configuration); // Note: before UseRouting()
            app.UseRouting();
        }
```

> Once you have configured the `UseEazyXssWrapper()` in Configure method of the Startup.cs file, 
> you're ready to define the `XssOptions` in the `app.settings.json`.

###### appsettings
 
```yaml
  "XssOptions": {
    "Enabled": true
  }
```

## Contributing
Please do open issues if you spot any bugs, or would like to suggest new features/changes.
