//using Duende.IdentityServer.AspNetIdentity;
//using Duende.IdentityServer.Services;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Shopping.IdentityServer.Configuration;
//using Shopping.IdentityServer.Model;
//using Shopping.ProductAPI.Model.Context;

//var builder = WebApplication.CreateBuilder(args);

//var connection = builder.Configuration["MySqlConnection:MySqlConnectionString"];

//builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(
//    connection,
//    new MySqlServerVersion(new Version(5, 7, 40)))
//);

//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddEntityFrameworkStores<MySqlContext>()
//    .AddDefaultTokenProviders();

//var builderServices = builder.Services.AddIdentityServer(options =>
//{
//    options.Events.RaiseErrorEvents = true;
//    options.Events.RaiseInformationEvents = true;
//    options.Events.RaiseFailureEvents = true;
//    options.Events.RaiseSuccessEvents = true;
//    options.EmitStaticAudienceClaim = true;
//})
//    .AddInMemoryIdentityResources(IdentityConfiguration.IdentityResources)
//    .AddInMemoryApiScopes(IdentityConfiguration.ApiScopes)
//    .AddInMemoryClients(IdentityConfiguration.Clients)
//    .AddAspNetIdentity<ApplicationUser>();

//builder.Services.AddScoped<IDbInitializer, DbInitializer>();
//builder.Services.AddScoped<IProfileService, ProfileService>();

//builderServices.AddDeveloperSigningCredential();

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//var initializer = app.Services.CreateScope().ServiceProvider.GetService<IDbInitializer>();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseIdentityServer();

//app.UseAuthorization();

//initializer.Initialize();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();