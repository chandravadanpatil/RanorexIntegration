﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace github_test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
          /// <summary>
          /// The class representing the github_testRepository element repository.
          /// </summary>
          [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
          [RepositoryFolder("e1e09083-9a0e-4c49-999c-03e459171ff5")]
          public partial class github_testRepository : RepoGenBaseFolder
          {
                    static github_testRepository instance = new github_testRepository();

                    /// <summary>
                    /// Gets the singleton class instance representing the github_testRepository element repository.
                    /// </summary>
                    [RepositoryFolder("e1e09083-9a0e-4c49-999c-03e459171ff5")]
                    public static github_testRepository Instance
                    {
                              get { return instance; }
                    }

                    /// <summary>
                    /// Repository class constructor.
                    /// </summary>
                    public github_testRepository() 
                              : base("github_testRepository", "/", null, 0, false, "e1e09083-9a0e-4c49-999c-03e459171ff5", ".\\RepositoryImages\\github_testRepositorye1e09083.rximgres")
                    {
                    }

#region Variables

#endregion

                    /// <summary>
                    /// The Self item info.
                    /// </summary>
                    [RepositoryItemInfo("e1e09083-9a0e-4c49-999c-03e459171ff5")]
                    public virtual RepoItemInfo SelfInfo
                    {
                              get
                              {
                                        return _selfInfo;
                              }
                    }
          }

          /// <summary>
          /// Inner folder classes.
          /// </summary>
          [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
          public partial class github_testRepositoryFolders
          {
          }
#pragma warning restore 0436
}
