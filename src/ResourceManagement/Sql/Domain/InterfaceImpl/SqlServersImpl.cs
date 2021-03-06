// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition;
    using Microsoft.Azure.Management.Sql.Fluent.Models;

    internal partial class SqlServersImpl 
    {
        /// <summary>
        /// Begins a definition for a new resource.
        /// This is the beginning of the builder pattern used to create top level resources
        /// in Azure. The final method completing the definition and starting the actual resource creation
        /// process in Azure is  Creatable.create().
        /// Note that the  Creatable.create() method is
        /// only available at the stage of the resource definition that has the minimum set of input
        /// parameters specified. If you do not see  Creatable.create() among the available methods, it
        /// means you have not yet specified all the required input settings. Input settings generally begin
        /// with the word "with", for example: <code>.withNewResourceGroup()</code> and return the next stage
        /// of the resource definition, as an interface in the "fluent interface" style.
        /// </summary>
        /// <param name="name">The name of the new resource.</param>
        /// <return>The first stage of the new resource definition.</return>
        SqlServer.Definition.IBlank Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsCreating<SqlServer.Definition.IBlank>.Define(string name)
        {
            return this.Define(name) as SqlServer.Definition.IBlank;
        }

        /// <summary>
        /// Gets the SQL Server Firewall Rules API entry point.
        /// </summary>
        Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRuleOperations Microsoft.Azure.Management.Sql.Fluent.ISqlServersBeta.FirewallRules
        {
            get
            {
                return this.FirewallRules() as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRuleOperations;
            }
        }

        /// <summary>
        /// Gets the SQL Server Database API entry point.
        /// </summary>
        Microsoft.Azure.Management.Sql.Fluent.ISqlDatabaseOperations Microsoft.Azure.Management.Sql.Fluent.ISqlServersBeta.Databases
        {
            get
            {
                return this.Databases() as Microsoft.Azure.Management.Sql.Fluent.ISqlDatabaseOperations;
            }
        }

        /// <summary>
        /// Gets the SQL Server Elastic Pools API entry point.
        /// </summary>
        Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPoolOperations Microsoft.Azure.Management.Sql.Fluent.ISqlServersBeta.ElasticPools
        {
            get
            {
                return this.ElasticPools() as Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPoolOperations;
            }
        }
    }
}