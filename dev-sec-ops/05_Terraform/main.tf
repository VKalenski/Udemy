terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=2.96.0"
    }
  }
}

provider "azurerm" {
  features {}
  skip_provider_registration = "true"
}

resource "azurerm_resource_group" "example" {
  name     = "example"
  location = "East US"
}

resource "azurerm_storage_account" "example" {
  name                     = "northernstor7778"
  resource_group_name      = azurerm_resource_group.example.name
  location                 = azurerm_resource_group.example.location
  account_tier             = "Standard"
  account_replication_type = "GRS"
}