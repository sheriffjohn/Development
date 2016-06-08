//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
//using Microsoft.Owin;
//using Microsoft.Owin.Security.Cookies;
//using Owin;

//public class AppUser : IdentityUser
//{
//    //add your custom properties which have not included in IdentityUser before
//    public string MyExtraProperty { get; set; }
//}

//public class AppRole : IdentityRole
//{
//    public AppRole() : base() { }
//    public AppRole(string name) : base(name) { }
//    // extra properties here 
//}
//public class MyDbContext : IdentityDbContext<AppUser>
//{
//    public System.Data.Entity.DbSet<SimpleWebStore.Domain.Entities.Product> Products { get; set; }
//    // Other part of codes still same 
//    // You don't need to add AppUser and AppRole 
//    // since automatically added by inheriting form IdentityDbContext<AppUser>
//}
//public class AppUserManager : UserManager<AppUser>
//{
//    public AppUserManager(IUserStore<AppUser> store)
//        : base(store)
//    {
//    }

//    // this method is called by Owin therefore best place to configure your User Manager
//    public static AppUserManager Create(
//        IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
//    {
//        var manager = new AppUserManager(
//            new UserStore<AppUser>(context.Get<MyDbContext>()));

//        // optionally configure your manager
//        // ...

//        return manager;
//    }
//}

//namespace MyAppNamespace
//{
//    public class IdentityConfig
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            app.CreatePerOwinContext(() => new MyDbContext());
//            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
//            app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) =>
//                new RoleManager<AppRole>(
//                    new RoleStore<AppRole>(context.Get<MyDbContext>())));

//            app.UseCookieAuthentication(new CookieAuthenticationOptions
//            {
//                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
//                LoginPath = new PathString("/Home/Login"),
//            });
//        }
//    }
//}