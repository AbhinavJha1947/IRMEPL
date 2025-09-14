using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Infrastructure.Helpers
{
    public sealed class TransactionDecorator : IDisposable
    {
        private TransactionScope _scope;
        private Transaction _transactionToUse;
        private TransactionScopeOption _scopeOption;
        private TimeSpan _scopeTimeout;
        private TransactionOptions _transactionOptions;
        private EnterpriseServicesInteropOption _interopOption;
        private readonly string _dataProvider;

        public TransactionDecorator(IConfiguration config)
        {
            _dataProvider = config.GetConnectionString("DefaultConnection");
        }
        public TransactionDecorator()
        {
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope();
        }
        public TransactionDecorator(Transaction transactionToUse)
        {
            _transactionToUse = transactionToUse;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_transactionToUse);
        }
        public TransactionDecorator(TransactionScopeOption scopeOption)
        {
            _scopeOption = scopeOption;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_scopeOption);
        }
        public TransactionDecorator(Transaction transactionToUse, TimeSpan scopeTimeout)
        {
            _transactionToUse = transactionToUse;
            _scopeTimeout = scopeTimeout;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_transactionToUse, _scopeTimeout);
        }
        public TransactionDecorator(TransactionScopeOption scopeOption, TimeSpan scopeTimeout)
        {
            _scopeOption = scopeOption;
            _scopeTimeout = scopeTimeout;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_scopeOption, _scopeTimeout);
        }
        public TransactionDecorator(TransactionScopeOption scopeOption, TransactionOptions transactionOptions)
        {
            _scopeOption = scopeOption;
            _transactionOptions = transactionOptions;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_scopeOption, _transactionOptions);
        }
        public TransactionDecorator(Transaction transactionToUse, TimeSpan scopeTimeout, EnterpriseServicesInteropOption interopOption)
        {
            _transactionToUse = transactionToUse;
            _scopeTimeout = scopeTimeout;
            _interopOption = interopOption;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_transactionToUse, _scopeTimeout, _interopOption);
        }
        public TransactionDecorator(TransactionScopeOption scopeOption, TransactionOptions transactionOptions, EnterpriseServicesInteropOption interopOption)
        {
            _scopeOption = scopeOption;
            _transactionOptions = transactionOptions;
            _interopOption = interopOption;
            if (_dataProvider != "System.Data.OleDb")
                _scope = new TransactionScope(_scopeOption, _transactionOptions, _interopOption);
        }
        public void Complete()
        {
            if (_scope != null)
                _scope.Complete();
        }

        public void Dispose()
        {
            if (_dataProvider != "System.Data.OleDb")
                if (_scope != null)
                    _scope.Dispose();
        }

    }

}
