using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMindTest.Controllers;
using VirtualMindTest.Models;
using System.Net;
using System.Collections.Generic;
using VirtualMindTest;
using System.Web.Http.Results;

namespace VirtualMind.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AltaUsuarios()
        {
            UsuariosController userController = new UsuariosController();
            UserTable user = new UserTable();
            user.id = 4;
            user.nombre = "Brian";
            user.apellido = "Bayarri";
            user.email = "brian15@hotmail.com";
            user.password = "brianeze";
            var result = userController.PostUserTable(user) as CreatedAtRouteNegotiatedContentResult<UserTable>;
           
            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteValues["id"], result.Content.id);
    
        }
        [TestMethod]
        public void BajaUsuarios()
        {
            var userController = new UsuariosController();
        
            var result = userController.DeleteUserTable(3) as OkNegotiatedContentResult<UserTable>;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void UpdateUsuarios()
        {
            var userController = new UsuariosController();
            UserTable user = new UserTable();
            user.id = 4;
            user.nombre = "Brian";
            user.apellido = "Bayarri";
            user.email = "brian15@hotmail.com";
            user.password = "mundial";
            userController.PutUserTable(4,user);
       
            var result = userController.PutUserTable(user.id, user) as StatusCodeResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

    }
}
