# Driving School Application
## What is it?

A (n unfinished) demo application for ASP.NET Webforms. Demonstrates a couple of things:

* Use of SQLite with the ASP.NET stack
* Use of Dapper lightweight ORM
* Dependency injection (using Autofac) to wire up ObjectDataSources on the Webforms. 
  The goal is to make the fetching of data on to the Webform as declarative as 
  possible and avoid the "hundreds of lines of code in the Page_Load event handler" 
  antipattern that you too often see with Webforms projects.
* Use of the "SlowCheetah" VS extension to apply Web config transforms to files other 
  than Web.config in the project (in this case, the NLog configuration file)

As both Webforms is declining in popularity and Web.config will probably disppear in 
some future version of ASP.NET, this is probably of historical interest only.


# Requirements

* Visual Studio 2015
* SlowCheetah extension
