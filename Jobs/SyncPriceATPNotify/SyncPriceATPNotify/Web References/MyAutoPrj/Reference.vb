﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace MyAutoPrj
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="AutoJobSoap", [Namespace]:="MyAdvantechWS")>  _
    Partial Public Class AutoJob
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private HelloKittyClockOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SyncCatalogPriceATPOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.SyncPriceATPNotify.My.MySettings.Default.SyncPriceATPNotify_MyAutoPrj_AutoJob
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event HelloKittyClockCompleted As HelloKittyClockCompletedEventHandler
        
        '''<remarks/>
        Public Event SyncCatalogPriceATPCompleted As SyncCatalogPriceATPCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechWS/HelloKittyClock", RequestNamespace:="MyAdvantechWS", ResponseNamespace:="MyAdvantechWS", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function HelloKittyClock() As String
            Dim results() As Object = Me.Invoke("HelloKittyClock", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub HelloKittyClockAsync()
            Me.HelloKittyClockAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub HelloKittyClockAsync(ByVal userState As Object)
            If (Me.HelloKittyClockOperationCompleted Is Nothing) Then
                Me.HelloKittyClockOperationCompleted = AddressOf Me.OnHelloKittyClockOperationCompleted
            End If
            Me.InvokeAsync("HelloKittyClock", New Object(-1) {}, Me.HelloKittyClockOperationCompleted, userState)
        End Sub
        
        Private Sub OnHelloKittyClockOperationCompleted(ByVal arg As Object)
            If (Not (Me.HelloKittyClockCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HelloKittyClockCompleted(Me, New HelloKittyClockCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("MyAdvantechWS/SyncCatalogPriceATP", RequestNamespace:="MyAdvantechWS", ResponseNamespace:="MyAdvantechWS", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SyncCatalogPriceATP() As Boolean
            Dim results() As Object = Me.Invoke("SyncCatalogPriceATP", New Object(-1) {})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub SyncCatalogPriceATPAsync()
            Me.SyncCatalogPriceATPAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SyncCatalogPriceATPAsync(ByVal userState As Object)
            If (Me.SyncCatalogPriceATPOperationCompleted Is Nothing) Then
                Me.SyncCatalogPriceATPOperationCompleted = AddressOf Me.OnSyncCatalogPriceATPOperationCompleted
            End If
            Me.InvokeAsync("SyncCatalogPriceATP", New Object(-1) {}, Me.SyncCatalogPriceATPOperationCompleted, userState)
        End Sub
        
        Private Sub OnSyncCatalogPriceATPOperationCompleted(ByVal arg As Object)
            If (Not (Me.SyncCatalogPriceATPCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SyncCatalogPriceATPCompleted(Me, New SyncCatalogPriceATPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")>  _
    Public Delegate Sub HelloKittyClockCompletedEventHandler(ByVal sender As Object, ByVal e As HelloKittyClockCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class HelloKittyClockCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")>  _
    Public Delegate Sub SyncCatalogPriceATPCompletedEventHandler(ByVal sender As Object, ByVal e As SyncCatalogPriceATPCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SyncCatalogPriceATPCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
End Namespace
