2022/10/21
Built the individual default application-ASP.NET Core (MVC)
using HTTPS
-prepereded my name - KaderBokkStore
-Intivual account Authentication
-Added Razor runtime-


create GITHUB repo and then reviewed the default 

--TEST and RUN working..


This Project is build with ASP.NET MVC CORE 3.1 usig HTTPS, individual account authentication..
the scenerio
2022/10/26
I search bootswatch.com and select theme.
 I choose "cosmo" theme and dowloaded bootsrapt.css.
I add to wwwroot>lib>bootsrapt>dist>css location.
when I add it I rename to old bootsrap.css to bootsrapt1.css because I want to keep it for any came back. Then, I add to layout.cshtml page.
I changed <style> bootsrapt.min.css link to bootsrapt.css.
I changed the nav class from nav-light to navbar dark and and bg-white to bg-primary and I changed  'footer' too.  and remove text-dark from line 23.
I remove references to 'text-dark' in  ' _LoginPartial.cshtml' page.
Test and Run.....It look good.
I addtional third party tool script to use
jquery UI: use same link in website.
DataTables:  I copy link from website, and paste to _layout.cdhtml page with <link> and <script> .
SweetAlert: I copy link from website, and paste in _layout.cdhtml page. "<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
Font Awesome: I add the free kit with <script> tag and I change "registere and Login"  with icons.
Toastr: i copied  Minified link from website and paste layout page.
change  layout.cshtml page 
test and run.....Working
2022/10/30
-check all part untill boostrapt
I add a dropdown menu to the Navbar in Views/Shared/_Layout.cshtml.
-Changed powerpoint part for dropdown menu. I add but doesnt work. I tried again, and I delete and type code again. 
Test and run . Its working..
I think, i made some spelling mistake. 
- When i adding dropdown menu register and login menu were change location. I change "register and login" menus location. So i change location  "<partial name="_LoginPartial" />" in _Layou.cshtml.
my cosmo template supports dropdown background color white and selection color gray.
I change dropdown to general manegement
2022/11/01
check all part untill Add Project & Modify
I following powepoint untill modify
-add 3 new NET Core class library to apptication
1.KadersBooks.DataAccess
2.KadersBooks.Models
3.KadersBooks.Utility
I cutting 'Data' folder and paste to.KadersBokks,DataAccess project.
Install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer page.
when I installed it gave me error about Package version.
I updated version to 5.10.11.(same powerpoint)
I delete Migration but i keep this file in my computer. It maybe give it error. :)
I modify the namespace to reflect the project.
I deleted all Class1.cs file in the additional class library.
I moved models folder in to KadersBooks.Models, and deleted orginal folder.
Modify Views>Share>Error.cshtml
I added References project.(.DataAccess and Models)
Rename Models folder to ViewModels.
i change the ErrorViewModels,cs namespace .Models.ViewModels.
I built project but it has 2 error.
I modifying Startup.cs service 'AddContext' with the using statement.
Built and Run  but....still have error
**********20:00***************
change view file location and run but i have still 2 error ..
I tried something:
change namespace and file location--not working
change location in statup.cs file controller to controllers/ area to areas--not working---undo
change "=" to ":" --not working--undo
move all views folder to areas ---not working--undo
delete views folder in main app---not working--undo
i decided so tried and i sent email Mr.Steel....
2022/11/02
12 noon
viewsmodesl error is fixed with quick fix option 
choose add redicted public class and fix
run error still continue but i am continue assignment part
I changed views folder.
I add  class name is SD.cs in KadersBooks.Utility.
I add KadersBooks.Models project reference to main project.
I add project referances to Models and Utility in the DataAccess project.
I added an area named 'Customers' to the Areas section, and change routes in the Startup.cs file like outlined in the ScaffoldingReadMe.txt.
I cutting HomeController.cs file and paste Area>Customer>Controller folder.
Defined controller is in the Customer Area.
Cutting views>Home folder and paste views folder, and modify HomeController namespace.
I continue but I cant test, so I changed my mind and I came back all changes.  I use gitup change section for came back.
Then I try again part by part from the bootsrap part.
 I repeat the above parts and....
TEST and RUN ....It WORKING.......with theme because i copied viewstart and viewImport file. Funny day..

**********19:00*********
I continue built my project by following direction.
I add new Admin in the Areas. Then I delete Data and Models folder coming up with admin.
I deleted Controllers folder.
Finaly,  It's FINISH PART1...........
I check all part and Test again,
Everythink ok. 

2022/11/03

I check all part and test. Its working. I hope it is working too at school computer.
Review my readme.
I update all project GitHup.









