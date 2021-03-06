using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System;

namespace XaeiOS.Security
{
    public sealed class RootPrincipal : IPrincipal
    {
        internal RootPrincipal(RootIdentity identity)
        {
            Identity = identity;
        }

        #region IPrincipal Members

        public IIdentity Identity
        {
            get;
            private set;
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
