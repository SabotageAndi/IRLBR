#/bin/bash

export resourceGroupName=irlbr
export storageAccountName="$resourceGroupName_storageAccount"
export region=northeurope

az login
az account set --subscription "Visual Studio Premium with MSDN"
az group create --name $resourceGroupName --location $region

az storage account create --name $storageAccountName --location $region --resource-group $resourceGroupName --sku Standard_LRS


az functionapp create --resource-group $resourceGroupName --consumption-plan-location $region \
--name <app_name> --storage-account  $storageAccountName  