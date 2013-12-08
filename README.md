pjsip4net
=========
A pjsip (http://www.pjsip.org/) user agent .Net wrapper.
pjsip4net is an attempt to project procedural pjsua high level API into convenient and easy to use OOP form. The library itself tries to be pjsip version agnostic, allowing you to switch pjsip.dll versions with no need to recompile your application code.   

Pjsip version supported
-----------
Currently only old 1.x branch version is supported. The code is distributed with custom built pjsip 1.4 dll file. No other versions were tested, however one can develop its own interop code version and plug it into the application. If you do, please, send me a pull request.

Roadmap
-----------
Things to come in order of importance:
  * pjsip 2.x line support
  * mono support
  * x64 build

Configuration
-----------
There are a number of things one should configure in order to tune pjsip within particular environment. These things include:
  * Signaling transport - you can choose which transport to send SIP packets over (UDP, TCP or TLS), to which port to bind to;
  * Media - enable or disable SRTP, specify capture and playback devices, enable or disable VAD;
  * Network settings - enable or disable NAT traversal protocols, specify proxies, DNS servers;
  * Accounts - specify accounts you want your user agent to register automatically upon startup. You can always register accounts dynamically with your application code;
  * User agent settings - enable or disable auto answer, or auto conference, specify maximum number of simultaneous calls allowed.

There are several ways to configure library:
  * app.cfg file. Library comes with builtin support for configuration provided in standard .Net configuration files. You have to tell pjsip4net to use this source of configuration at startup <todo:gist>
  * custom config source, by implementing `IConfigurationProvider`. To plug it in, you have to tell the library to use it at startup phase (https://gist.github.com/siniypin/5951687). In fact the previous option is an implementation of this interface by `CfgFileConfigurationProvider`;
  * configure programmatically, by supplying blocks of code that configure options at runtime (<todo:gist>);

Dependency injection
-----------
pjsip4net leverages the dependency injection principle by means of pluggable DI-containers it uses to loose couple the code and to enable automatic library's public contracts resolution within applications that already use DI-containers. 
If no container provided, the library will use its own simple container internally. Currently the only external container supported is Castle Windsor (http://docs.castleproject.org/Windsor.MainPage.ashx). 
To plug your own container instance into library you have to tell it to use it startup phase <todo:gist>

Examples
-----------
The library comes with console application one can use to test if configuration options specified are correct within particular environment or to study application code. Almost every scenario is covered within this small application: registering accounts, issuing calls, sending instant messages, adding buddies, specifying codecs and media devices. 
In order to build a library you have to run build.bat file first. pjsip4net uses UpperCut project to run builds. If you want to know more about how it works, please refer to UpperCut documentation (http://uppercut.pbworks.com/w/page/9022442/FrontPage). 

Debugging
-----------
Running the test console within the managed debugger you may encounter an "vshost stopped working" error in certain scenarios. To avoid this problem please run test console application by running executable file your compiler generates and attach a debugger later (VS menu: Tools -> Attach to process...).
