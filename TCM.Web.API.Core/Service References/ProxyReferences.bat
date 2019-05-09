dotnet tool install --global dotnet-svcutil --version 2.0.0

rmdir /s /q ProxyBooking
rmdir /s /q ProxyCash
rmdir /s /q ProxyCost
rmdir /s /q ProxyLightCustomer
rmdir /s /q ProxyLightOrder
rmdir /s /q ProxyNLuxHolder
rmdir /s /q ProxyNLuxPayment
rmdir /s /q ProxyXFMAccount
rmdir /s /q ProxyXFMAggregatedOrder
rmdir /s /q ProxyXFMFund
rmdir /s /q ProxyXFMOrder
rmdir /s /q ProxyXFMOrganization
rmdir /s /q ProxyXFMPayment
rmdir /s /q ProxyXFMPricing
rmdir /s /q ProxyXFMUserSettings


mkdir ProxyBooking
mkdir ProxyCash
mkdir ProxyCost
mkdir ProxyLightCustomer
mkdir ProxyLightOrder
mkdir ProxyNLuxHolder
mkdir ProxyNLuxPayment
mkdir ProxyXFMAccount
mkdir ProxyXFMAggregatedOrder
mkdir ProxyXFMFund
mkdir ProxyXFMOrder
mkdir ProxyXFMOrganization
mkdir ProxyXFMPayment
mkdir ProxyXFMPricing
mkdir ProxyXFMUserSettings

 

dotnet-svcutil http://tcmbop2019.bise.financialsolutions.se:820/WSCustomerService.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyLightCustomer" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyLightCustomer
dotnet-svcutil http://tcmbop2019.bise.financialsolutions.se:840/WSOrderService.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyLightOrder" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyLightOrder
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSBooking.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyBooking" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyBooking 
dotnet-svcutil http://tcmdg2012.bise.financialsolutions.se:800/WSCash.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyCash" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyCash
dotnet-svcutil http://tcmseb2012.bise.financialsolutions.se:800/WSCost.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyCost" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyCost
dotnet-svcutil http://tcmnordeaapp.bise.financialsolutions.se:8099/WSHolder.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyNLuxHolder" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyNLuxHolder
dotnet-svcutil http://tcmnordeaapp.bise.financialsolutions.se:8099/WSPayment.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyNLuxPayment" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyNLuxPayment
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSAccount.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMAccount" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMAccount
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSAggregatedOrder.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMAggregatedOrder" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMAggregatedOrder
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSFund.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMFund" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMFund
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSOrder.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMOrder" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMOrder
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSOrganization.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMOrganization" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMOrganization
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSPayment.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMPayment" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMPayment
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSPricing.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMPricing" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMPricing
dotnet-svcutil http://tcmrobur2012.bise.financialsolutions.se:801/WSPersist.svc?wsdl -edb -n "*,TCM.Web.Business.ProxyXFMUserSettings" -ser Auto -ct System.Collections.Generic.List`1 -o Reference.cs -d ProxyXFMUserSettings

   
