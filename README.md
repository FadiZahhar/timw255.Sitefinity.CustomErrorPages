# timw255.Sitefinity.CustomErrorPages

This is a custom module to enable user-configurable error pages in Sitefinity.


## Installation

In your web.config, add the following:

```xml
<customErrors mode="On">
	<error statusCode="404" redirect="~/8ec96125-02ce-47e2-a545-0eba4192dc7d" />
</customErrors>

</system.web>
	<httpModules>
		<add name="CustomErrorsModule" type="timw255.Sitefinity.CustomErrorPages.CustomErrorModule, timw255.Sitefinity.CustomErrorPages" />
	</httpModules>
</system.web>

<system.webServer>
    <httpErrors errorMode="Custom">
      <remove statusCode="404" subStatusCode="-1" />
      <error statusCode="404" prefixLanguageFilePath="" path="/8ec96125-02ce-47e2-a545-0eba4192dc7d.aspx" responseMode="ExecuteURL" />
    </httpErrors>
    <modules runAllManagedModulesForAllRequests="true">
      <remove name="CustomErrorsModule" />
      <add name="CustomErrorsModule" type="timw255.Sitefinity.CustomErrorPages.CustomErrorModule, timw255.Sitefinity.CustomErrorPages" />
    </modules>
</system.webServer>
```

_This is a self-installing project. Other than the web.config changes above, you just need to clone the repo, add it to your solution, reference it, then build._