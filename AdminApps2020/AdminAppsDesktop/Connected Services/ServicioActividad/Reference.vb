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


Namespace ServicioActividad
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServicioActividad.IActividadWcf")>  _
    Public Interface IActividadWcf
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/SeleccionarTodos", ReplyAction:="http://tempuri.org/IActividadWcf/SeleccionarTodosResponse")>  _
        Function SeleccionarTodos() As Entidades.ActividadENT()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/SeleccionarTodos", ReplyAction:="http://tempuri.org/IActividadWcf/SeleccionarTodosResponse")>  _
        Function SeleccionarTodosAsync() As System.Threading.Tasks.Task(Of Entidades.ActividadENT())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/SeleccionarUsuario", ReplyAction:="http://tempuri.org/IActividadWcf/SeleccionarUsuarioResponse")>  _
        Function SeleccionarUsuario() As Entidades.ActividadENT()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/SeleccionarUsuario", ReplyAction:="http://tempuri.org/IActividadWcf/SeleccionarUsuarioResponse")>  _
        Function SeleccionarUsuarioAsync() As System.Threading.Tasks.Task(Of Entidades.ActividadENT())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/Insertar", ReplyAction:="http://tempuri.org/IActividadWcf/InsertarResponse")>  _
        Function Insertar(ByVal actividadENT As Entidades.ActividadENT) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/Insertar", ReplyAction:="http://tempuri.org/IActividadWcf/InsertarResponse")>  _
        Function InsertarAsync(ByVal actividadENT As Entidades.ActividadENT) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/Actualizar", ReplyAction:="http://tempuri.org/IActividadWcf/ActualizarResponse")>  _
        Function Actualizar(ByVal actividadENT As Entidades.ActividadENT) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/Actualizar", ReplyAction:="http://tempuri.org/IActividadWcf/ActualizarResponse")>  _
        Function ActualizarAsync(ByVal actividadENT As Entidades.ActividadENT) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/BuscarActividad", ReplyAction:="http://tempuri.org/IActividadWcf/BuscarActividadResponse")>  _
        Function BuscarActividad(ByVal campo As String, ByVal texto As String) As Entidades.ActividadENT()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/BuscarActividad", ReplyAction:="http://tempuri.org/IActividadWcf/BuscarActividadResponse")>  _
        Function BuscarActividadAsync(ByVal campo As String, ByVal texto As String) As System.Threading.Tasks.Task(Of Entidades.ActividadENT())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/BuscarActividadFecha", ReplyAction:="http://tempuri.org/IActividadWcf/BuscarActividadFechaResponse")>  _
        Function BuscarActividadFecha(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As Entidades.ActividadENT()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IActividadWcf/BuscarActividadFecha", ReplyAction:="http://tempuri.org/IActividadWcf/BuscarActividadFechaResponse")>  _
        Function BuscarActividadFechaAsync(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As System.Threading.Tasks.Task(Of Entidades.ActividadENT())
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IActividadWcfChannel
        Inherits ServicioActividad.IActividadWcf, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ActividadWcfClient
        Inherits System.ServiceModel.ClientBase(Of ServicioActividad.IActividadWcf)
        Implements ServicioActividad.IActividadWcf
        
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
        
        Public Function SeleccionarTodos() As Entidades.ActividadENT() Implements ServicioActividad.IActividadWcf.SeleccionarTodos
            Return MyBase.Channel.SeleccionarTodos
        End Function
        
        Public Function SeleccionarTodosAsync() As System.Threading.Tasks.Task(Of Entidades.ActividadENT()) Implements ServicioActividad.IActividadWcf.SeleccionarTodosAsync
            Return MyBase.Channel.SeleccionarTodosAsync
        End Function
        
        Public Function SeleccionarUsuario() As Entidades.ActividadENT() Implements ServicioActividad.IActividadWcf.SeleccionarUsuario
            Return MyBase.Channel.SeleccionarUsuario
        End Function
        
        Public Function SeleccionarUsuarioAsync() As System.Threading.Tasks.Task(Of Entidades.ActividadENT()) Implements ServicioActividad.IActividadWcf.SeleccionarUsuarioAsync
            Return MyBase.Channel.SeleccionarUsuarioAsync
        End Function
        
        Public Function Insertar(ByVal actividadENT As Entidades.ActividadENT) As Integer Implements ServicioActividad.IActividadWcf.Insertar
            Return MyBase.Channel.Insertar(actividadENT)
        End Function
        
        Public Function InsertarAsync(ByVal actividadENT As Entidades.ActividadENT) As System.Threading.Tasks.Task(Of Integer) Implements ServicioActividad.IActividadWcf.InsertarAsync
            Return MyBase.Channel.InsertarAsync(actividadENT)
        End Function
        
        Public Function Actualizar(ByVal actividadENT As Entidades.ActividadENT) As Integer Implements ServicioActividad.IActividadWcf.Actualizar
            Return MyBase.Channel.Actualizar(actividadENT)
        End Function
        
        Public Function ActualizarAsync(ByVal actividadENT As Entidades.ActividadENT) As System.Threading.Tasks.Task(Of Integer) Implements ServicioActividad.IActividadWcf.ActualizarAsync
            Return MyBase.Channel.ActualizarAsync(actividadENT)
        End Function
        
        Public Function BuscarActividad(ByVal campo As String, ByVal texto As String) As Entidades.ActividadENT() Implements ServicioActividad.IActividadWcf.BuscarActividad
            Return MyBase.Channel.BuscarActividad(campo, texto)
        End Function
        
        Public Function BuscarActividadAsync(ByVal campo As String, ByVal texto As String) As System.Threading.Tasks.Task(Of Entidades.ActividadENT()) Implements ServicioActividad.IActividadWcf.BuscarActividadAsync
            Return MyBase.Channel.BuscarActividadAsync(campo, texto)
        End Function
        
        Public Function BuscarActividadFecha(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As Entidades.ActividadENT() Implements ServicioActividad.IActividadWcf.BuscarActividadFecha
            Return MyBase.Channel.BuscarActividadFecha(fechaInicio, fechaFinal)
        End Function
        
        Public Function BuscarActividadFechaAsync(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As System.Threading.Tasks.Task(Of Entidades.ActividadENT()) Implements ServicioActividad.IActividadWcf.BuscarActividadFechaAsync
            Return MyBase.Channel.BuscarActividadFechaAsync(fechaInicio, fechaFinal)
        End Function
    End Class
End Namespace
