﻿using System;
using System.Data.Common;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbExtensions.Tests.Querying {
   
   [TestClass]
   public class SqlSetBehaviorForSqlServer {

      readonly DbConnection conn = System.Data.SqlClient.SqlClientFactory.Instance
         .CreateSqlServerConnectionForTests();

      [TestMethod]
      public void Use_Parameter_On_Skip() {

         var query = conn.From(SQL.SELECT("1"))
            .Skip(1)
            .GetDefiningQuery();

         Assert.AreEqual(1, query.ParameterValues.Count);
      }

      [TestMethod]
      public void Use_Parameter_On_Take() {

         var query = conn.From(SQL.SELECT("1"))
            .Take(1)
            .GetDefiningQuery();

         Assert.AreEqual(1, query.ParameterValues.Count);
      }

      [TestMethod]
      public void Use_Parameter_On_Skip_And_Take() {

         var query = conn.From(SQL.SELECT("1"))
            .Skip(1)
            .Take(1)
            .GetDefiningQuery();

         Assert.AreEqual(2, query.ParameterValues.Count);
      }
   }
}