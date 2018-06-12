namespace Shared
{
    public interface ISqlStoredProcedureSavable
    {
        string ToSqlSaveProcedureParameters();
        string ToSqlSaveProcedureParameters(in byte[] entityBytes);
    }
}
