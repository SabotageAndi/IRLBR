#/bin/bash

az login
az account set --subscription "Visual Studio Premium with MSDN"
az group create --name irlbr --location northeurope

az storage account create --name irlbr_storage --location northeurope --resource-group irlbr --sku Standard_LRS