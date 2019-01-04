# PlaidDemo: An application to demonstrate how to get transactions using [Plaid](plaid.com) and C#

Plaid is a free* (under 100 live credentials) API to get transactions and account balances from banks. This project is a quick demonstration of that.

#### To get it working:

1) Download the latest release from the [releases page](https://github.com/derekantrican/PlaidDemo/releases) or download the source and build
2) Apply for Plaid API keys on https://plaid.com
3) Start up the application, click on the Settings icon, and input your Plaid information (client_id, public_key, and secrets)
4) On the Settings window, on the "Bank Accounts" tab, click "Add New" and authorize bank accounts
5) Once you have connected the bank accounts you would like to, click "Save" on the settings window and return to the application
6) You can now use the application to retrieve bank accounts and transactions (either for specific accounts, specific banks, or for all accounts of all banks authorized)

![Image](https://i.imgur.com/1bBkqed.png)

*Since this is a demonstration of implementation of Plaid's API, I don't plan on updating this much. But feel free to fork this repository or submit issues*
