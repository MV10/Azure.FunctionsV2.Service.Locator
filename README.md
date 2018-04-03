Repository for code from my 2018-Apr-03 blog post:

### [Service Locator for Azure Functions V2](https://mcguirev10.com/2018/04/03/service-locator-azure-functions-v2.html)

The article explains why I went with the Service Locator "anti-pattern" -- but the short version is that Microsoft is working on correct dependency injection support for Azure Functions V2, so it didn't seem worthwhile to port the V1 DI system to V2, particularly since it relies on extensibility features (custom trigger bindings) that Microsoft considers unsupported.

---
