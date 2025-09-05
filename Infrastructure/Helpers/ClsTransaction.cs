using Microsoft.Extensions.Logging;
using System.Data;

namespace Infrastructure.Helpers
{
    public class ClsTransaction : IDisposable
    {
        private readonly ILogger<ClsTransaction> _logger;
        private IDbTransaction? _transaction;
        private bool _disposed = false;

        public ClsTransaction(ILogger<ClsTransaction> logger)
        {
            _logger = logger;
        }

        public IDbTransaction? CurrentTransaction => _transaction;

        public async Task<IDbTransaction> BeginTransactionAsync(IDbConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                _transaction = connection.BeginTransaction();
                _logger.LogDebug("Transaction started");
                return _transaction;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error beginning transaction");
                throw;
            }
        }

        public async Task CommitAsync()
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Commit();
                    _logger.LogDebug("Transaction committed");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error committing transaction");
                throw;
            }
        }

        public async Task RollbackAsync()
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Rollback();
                    _logger.LogDebug("Transaction rolled back");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error rolling back transaction");
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _transaction?.Dispose();
                _disposed = true;
                _logger.LogDebug("Transaction disposed");
            }
        }
    }
}
