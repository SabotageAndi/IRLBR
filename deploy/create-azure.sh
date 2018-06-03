#/bin/bash -x

set -x

export resourceGroupName=irlbr
export storageAccountKey=storageaccount
export storageAccountName=$resourceGroupName$storageAccountKey
export region=northeurope


az account show 1> /dev/null

if [ $? != 0 ];
then
	az login
fi

az account set --subscription "Visual Studio Premium with MSDN"
az group create --name $resourceGroupName --location $region

az storage account create --name $storageAccountName --location $region --resource-group $resourceGroupName --sku Standard_LRS


az functionapp create --resource-group $resourceGroupName --consumption-plan-location $region --name irlbr --storage-account  $storageAccountName  