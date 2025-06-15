using System.Text.Json.Serialization;

namespace Project.Contracts.Accounts;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AccountType
{
    Asset,
    Liability,
    Equity,
    Revenue,
    Expense
}