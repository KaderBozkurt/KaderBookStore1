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
2000-change view file location and run but i have still 2 error ..
2001-I tried something:
2002-change namespace and file location--not working
2003-change location in statup.cs file controller to controllers/ area to areas--not working---undo
2005-change "=" to ":" --not working--undo
2005-move all views folder to areas ---not working--undo
2006-delete views folder in main app---not working--undo
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
1900-I continue built my project by following direction.
19001-I add new Admin in the Areas. Then I delete Data and Models folder coming up with admin.
1903-I deleted Controllers folder.
1905-Finaly,  It's FINISH PART1...........
1910- check all part and Test again,
1911-Everythink ok. 

2022/11/03

1100-I check all part and test. Its working. I hope it is working too at school computer.
1105-Review my readme.
1130-I update all project GitHup.


2022/11/04
12:10- I clone githup with school computer but doesnt upload my project.I failed additional project.
1211- ask professor and advise delete repo and create new one 
1215- I try delete repo and create again but githup cant allow i use old project
1216-i ask someone and i realeze when i commit and push githup just save my main project 
1230- we create group with my classmate and we working on
1233- first we back up all project 
1236- create new repository and try upload my old file with visual studio but visual studio allow new project not use old project.
1300-create new repo but githup exsist my old repo and i have change name "KaderBookStore1" but we cant upload
1325- professor give me point
1330- my classmate advise it for check githup push way. that mean .git folder (actually it hidden). 
1340- first, all file select show in visual studio
1341-second we check .git folder in my repo folder and we see its wrong push way we have move this folder
1345- move .git folder without main project folder and change repository name 
1350- its working in my computer. right now, i see my all project in my reposity.when i go home i will try another computer.
1640- i try my destop computer and its working.
1659- But why doesn't github transfer automatically? I couldn't understand that. It doesn't say that we have to pay attention to this when we start a new project.
1736- GitHup Repository name : "KaderBookStore1"
      Local repo Name: "KaderBozkurtS"
      FIXED..... I will try school computer

      2022/11/07
1230-'build' the application and No error
1231-Review appsettings.json
1234-Add Migratin but gived error "Exception has been thrown by the target of an invocation."
1235- search the this error online and i found, that means my packages is doesnt macth main packages 
so i try update but its not working. 
1240-class time over and i will try fix agian at home.But i have PHP project and due date tomorrow.

   2022/11/10
1200-restart the second part(buil solution, review appsettings.json)
1207-Add migration and contuinue error "Exception has been thrown by the target of an invocation."
1208-It gives this error because the versions of NugET packages are different.
     I updated all packages from 5.0.11 to 3.1.16.
1222-Add migration  and it gave the error in the slides and I changed the default project part
    and working lets go next step.
       
       My migration name:'BookStoreMig'

1223-check migration file in KadersBokks.DataAccess
1238-update-database and succeeded and Done
1231-Review the update database in the SQLServer Object Explorer.
1232-RUN---No Error
1238-add new class file "Category.cs" in KadersBooks.Models
1258-add-migration 'AddCategoryDb'
1331- update and added using statement KadersBokks.Models
1332- error for Category class its same name but somathing worng...
    2022/11/11
1326- created Categories table but i cant see in SQL Server Object Explorer
      for fix: Refresh twice but i not see my table
           build again but still have same problem
1345- Let's break and refresh brain
1417- i opened my project school lab. but my database cant update 
1418-check my main project and its still working and i add my category table in database on my labtop but why doesnt work lab computer?
1430- i found some issuses about guthup when update my projet on githup, githup doesnt update my database.
so when clone my project at school computer it not show database table and SQL server.

1828- Start Part2.2
1848- Add folder Repository in KadersBooks.DataAccess class then add folder in Repository folder
1850-Add class implementations of interface in IRepository.cs
1909-add methods to use for CRUD
    Get item from database
    List of Categories
    Add object
    Remove object in IRepository.cs file
    Give it error about up and down in AddCategoryDb.cs file
1930- I realize my migration have more file because when i pulling it is come it 
       delete more file and fixed error
1949- Include the using statement and fix same error in power point
1951- Modify the code to create the constructor and dependency injection
2025- Type CRUD code from Repository.cs file in blackboard
2028- Create file ICategory.cs in Repository folder because we will use all patential models to be added the future
2042- Modify CategoryRepository.cs 

          Add using statement --   " using KaderBookStore.DataAccess.Data;
                                    using KadersBooks.DataAccess.Repository.IRepository;
                                    using KadersBooks.Models;"

2044- Review Repository.cs
2053- Implement the interface to update
2054- complete the remaining modification 
2100- I have error in class Models and Utility project this;
            "Severity Code Description Project File Line Column Suppression State Error MSB3541 Files has 
                invalid value "<<<<<<< HEAD". Illegal characters in path. KadersBooks.Models 
                    C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\Microsoft.
                     Common.CurrentVersion.targets 5460 5"
2108- I tried back with Git Change but when i built solution came back same error....
2130- selected "Show All File" for KadersBooks.Models and KadersBooks.Utility 
2135- I'm looking for the file with the error
2136- i found obj/KadersBooks.Utility.csproj.CoreCompileInputs.cache.. I found the following error;

        <<<<<<< HEAD
            61b0a04e9d39d20fc4dd991a8e0aea610d1844c2
            =======
            49e7df5118f4b03a306aef4b3d336903649e34c4
                >>>>>>> a2ee6a58678b3b82e265fe1c2dccabf3c4d44a79

2145-I deleted context for the file with the error and built again but i still have same error
        Let's break and refresh brain

2210- I thought of searching the internet for the error and i found same solution.Lets try...
2215- I found this solution; "Try to search the entire solution for the value and remove it from where it occurs, and
then delete the obj folder from your project. When you build again it should work.
The obj folders are hidden in Visual Studio. You can see them with a file explorer."    
2217-Deleted each obj folder for Models and Utility.
2220- Build Project and Fix...Thank you Internet
2327- add new interface in the IRepository/ISP_Call.cs extends IDisposable
2327- Install NuGet package is "Dapper"
2327- Implement this new class in repository class
2333- Add new class SP_Call.cs in the Repository folder
2333- Add a connection to the database and add using following;
            using KaderBookStore.DataAccess.Data;
            using KadersBooks.DataAccess.Repository.IRepository;


  2022/11/12
  1250- Add connection  to the database
  1255- Add using statement
  1308- Update the implementation of the ISP_Call interface
  1327-Add new interface to the IRepository
  ---------Break----------
  1806- add code " public class UnitOfWork : IUnitOfWork   " in UnitOfWork.cs
  1807- Changed interface to public interface in IUnitOfWork.cs
  1808- Add following code in Startup.cs;
        "using KaderBookStore.DataAccess.Data;
         using KadersBooks.DataAccess.Repository;
         using KadersBooks.DataAccess.Repository.IRepository;"
      
1813- Build and succeeded....

1838- Create controller is  inside Areas/Admin/Controllers/CategoryController.cs
1841- Add using "using KadersBooks.DataAccess.Repository.IRepository;"
1850- Add new Folder name is Controller in the Areas/View
1951- Add new 'Index': right click Areas/Views and create 'Index' Razor View with empty(without model) in the .Areas/Admin/Views/Shared/_Layout.cshtml 
1952- Copy and Paste code in Category Index View.txt file in the Assignment 2 folder
1954- Remove ViewData["Title"] = "Index"; and <h1>Index</h1>
1955-Save and Run.. and use:http://localhost:8600/Admin/Category {Admin/Cotegory}
        It showed like on the slide.

1957-Change code in _Layout.cshtml
1958-Remove Privary link and add Category link in dropdown menu" <a class="dropdown-item " asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>"
1958- Run and show up Category under dropdown menu and when i click it goes the Category List
1940- Add trash and Edit icon with Font Awesome 
1950- Create "category.js" file in wwroot/js and cut code about icon in Index.cshtml paste in "category.js"
1955- Call category.js file with @section like:@section Scripts{ script src="~/js/category.js"></script> } in Index.cshtml
1958- Run and Working but i cant see any name because i dont have data right now.
2000- Activete the 'Edit' and 'Delete' buttons
2002-Abb action method for upsert for is for create and for the edit in CategoryController.cs
2004- Gived some error and i add 'using KadersBooks.Models'
2013- Add category last return view()
2020- Create Razor view page Upsert.cshtml file in Adim/Views/Category
2021- Copy and paste code in category upsert view file on blackboard
2022-Create Partial view foe Edit|Back.
2022- Add _CreateAndBackToListButton.cshtml partial view in Views/Shared folder 
2033- Listed and add asp-action button in  _CreateAndBackToListButton.cshtml 

2022/11/13

1200-Create another partial view __EditAndBackToListButton.cshtml file and add asp-action with @model razor statement
1201-Modify Upsert.cshtml with @model
1203-Add asp-action to the Index.cshtmlpage modify
1205-run and working but i cant add category
1207-Navigate to category/create new category
1210--Change title with @title variable
1211-add @section and call script
1212- tested but i cant create new category
1218- I send email to prefessor...but i have to finis all part maybe will be fix
1230-Create Upsert POST action methodin the CategoryController.cs
1230- save method made void to IUnitOfWork.cs.
1231- Add this code "void Save();" under 'public interface IUnitOfWork : IDisposable' in the IUnitOfWork.cs file
1231- Remove the _db.SaveChanges() method in CategoryRepository.cs
1233- Add the code " _unitOfWork.Save();
                return RedirectToAction(nameof(Index));   " in CategoryController.cs

1244-display correctly but i cant add new category why???
    -change asp-action but doesnt work
    -

1312-send email professor twice
???????????????????????/
1330-Add the API HTTPDelete in the CategoryController.cs
1331- implement with a delete method in category.js
1332-Add delete function in last part in category.js
1332-Add delete url function

1350-I HAVE BIG PROBLEM ABOUT ADD DATA IN CATEGORY 
  LETS BREAK

1615-Review all slayt and i found some spelling mistake and missing part
   ...Annotation("SqlServer:Identy", "1, 1") to Annotation("SqlServer:Identity", "1, 1")  in the AddCategoryDb.cs
   ....miss part "  T GetFirstOrDefault(                   in the IRepository.cs
                      Expression<Func<T, bool>> filter = null,
                         string includeProperties = null  );"


2022/11/14
1008- i add comment    //_db.SaveChanges(); and working bur it doesnt loading



