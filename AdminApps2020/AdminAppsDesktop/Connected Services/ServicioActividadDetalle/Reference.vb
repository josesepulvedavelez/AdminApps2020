﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServicioActividadDetalle
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServicioActividadDetalle.IActividadDetalleWcf")>  _
    Public Interface IActividadDetalleWcf
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadDetalleWcf/SeleccionarTodos", ReplyAction:="http://tempuri.org/IActividadDetalleWcf/SeleccionarTodosResponse")>  _
        Function SeleccionarTodos(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As Entidades.ActividadDetalleENT()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadDetalleWcf/SeleccionarTodos", ReplyAction:="http://tempuri.org/IActividadDetalleWcf/SeleccionarTodosResponse")>  _
        Function SeleccionarTodosAsync(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As System.Threading.Tasks.Task(Of Entidades.ActividadDetalleENT())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadDetalleWcf/Insertar", ReplyAction:="http://tempuri.org/IActividadDetalleWcf/InsertarResponse")>  _
        Function Insertar(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadDetalleWcf/Insertar", ReplyAction:="http://tempuri.org/IActividadDetalleWcf/InsertarResponse")>  _
        Function InsertarAsync(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadDetalleWcf/Actualizar", ReplyAction:="http://tempuri.org/IActividadDetalleWcf/ActualizarResponse")>  _
        Function Actualizar(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadDetalleWcf/Actualizar", ReplyAction:="http://tempuri.org/IActividadDetalleWcf/ActualizarResponse")>  _
        Function ActualizarAsync(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As System.Threading.Tasks.Task(Of Integer)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IActividadDetalleWcfChannel
        Inherits ServicioActividadDetalle.IActividadDetalleWcf, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ActividadDetalleWcfClient
        Inherits System.ServiceModel.ClientBase(Of ServicioActividadDetalle.IActividadDetalleWcf)
        Implements ServicioActividadDetalle.IActividadDetalleWcf
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function SeleccionarTodos(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As Entidades.ActividadDetalleENT() Implements ServicioActividadDetalle.IActividadDetalleWcf.SeleccionarTodos
            Return MyBase.Channel.SeleccionarTodos(actividadDetalleENT)
        End Function
        
        Public Function SeleccionarTodosAsync(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As System.Threading.Tasks.Task(Of Entidades.ActividadDetalleENT()) Implements ServicioActividadDetalle.IActividadDetalleWcf.SeleccionarTodosAsync
            Return MyBase.Channel.SeleccionarTodosAsync(actividadDetalleENT)
        End Function
        
        Public Function Insertar(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As Integer Implements ServicioActividadDetalle.IActividadDetalleWcf.Insertar
            Return MyBase.Channel.Insertar(actividadDetalleENT)
        End Function
        
        Public Function InsertarAsync(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As System.Threading.Tasks.Task(Of Integer) Implements ServicioActividadDetalle.IActividadDetalleWcf.InsertarAsync
            Return MyBase.Channel.InsertarAsync(actividadDetalleENT)
        End Function
        
        Public Function Actualizar(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As Integer Implements ServicioActividadDetalle.IActividadDetalleWcf.Actualizar
            Return MyBase.Channel.Actualizar(actividadDetalleENT)
        End Function
        
        Public Function ActualizarAsync(ByVal actividadDetalleENT As Entidades.ActividadDetalleENT) As System.Threading.Tasks.Task(Of Integer) Implements ServicioActividadDetalle.IActividadDetalleWcf.ActualizarAsync
            Return MyBase.Channel.ActualizarAsync(actividadDetalleENT)
        End Function
    End Class
End Namespace