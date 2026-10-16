
using LibraryManagement_Final.Data;
using LibraryManagement_Final.JWT;
using LibraryManagement_Final.Repos.Implementations;
using LibraryManagement_Final.Repos.Interfaces;
using LibraryManagement_Final.UnitOFWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LibraryManagement_Final
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection")));
            builder.Services.AddScoped(typeof(IGenericRepo<>), (typeof(GenericRepo<>)));
            builder.Services.AddScoped<IBookRepo, BookRepo>();
            builder.Services.AddScoped<IMemberRepo, MemberRepo>();
            builder.Services.AddScoped<IBorrowingRepo, BorrowingRepo>();
            builder.Services.AddScoped<IAuthRepo, AuthRepo>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWOrk>();
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            // Add services to the container.

            #region JWTValidationService
            builder.Services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(
                        builder.Configuration["JWT:Key"]
                        )),
                };
            });
            #endregion

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
