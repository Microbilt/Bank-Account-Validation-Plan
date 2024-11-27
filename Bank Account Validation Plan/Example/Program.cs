using System.Text.Json;
using System.Text.Json.Nodes;
using Bank_Account_Validation_Plan;
using Bank_Account_Validation_Plan.APIClients;
using Bank_Account_Validation_Plan.Model;

var bankAccountValidationPlanClient = new BankAccountValidationPlanClient("You_client_id", "You_client_secret", EnvironmentType.Sandbox);

Console.WriteLine("Test ABAAcctVerification Post:");

var ABAAcctVerificationRequestModel = JsonSerializer.Serialize<ABAAcctVerificationRequestModel>(new ABAAcctVerificationRequestModel()
{
    BankRoutingNumber = "011103093",
    BankAccountNumber = "19945192099"
});

var aBAAcctVerificationPost = bankAccountValidationPlanClient.ABAAcctVerificationClient.Post(ABAAcctVerificationRequestModel);
Console.WriteLine("GetReport = {0}", aBAAcctVerificationPost.ToString());
Console.ReadKey();