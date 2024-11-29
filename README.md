# Bank Account Validation Plan Client

A .NET client for consuming the Microbilt Bank Account Validation API.

API page - https://developer.microbilt.com/api/ABAAcctVerification

# Installation

`composer require Microbilt/Bank-Account-Validation-Plan`

# Quick Start

```
BankAccountValidationPlanClient bankAccountValidationPlanClient = new BankAccountValidationPlanClient("client_id", "client_secret");
```
# Configuration

`client_id` required

`client_secret` required

`EnvironmentType` optional (defaults to Production). Other option is Sandbox. 

# Usage
See https://developer.microbilt.com/api/ABAAcctVerification for the necessary parameters to pass in to each function.
For report created request model 
```
ABAAcctVerificationRequestModel reqModel = new ABAAcctVerificationRequestModel()
{
    BankRoutingNumber = "011103093",
    BankAccountNumber = "19945192099"
};
```
You can Serialize model for use with extension method ```.ToJson()``` in 'Extensions.cs'

All responses for all requests 'JsonObject', for get JSON string You can use ```.ToString()``` method