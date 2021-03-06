﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobApplicantWebCam.JobRecruitmentService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobRecruitmentService.JobRecruitmentWebServiceSoap")]
    public interface JobRecruitmentWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name byteArray from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveApplicantPicture", ReplyAction="*")]
        JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureResponse SaveApplicantPicture(JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveApplicantPictureRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveApplicantPicture", Namespace="http://tempuri.org/", Order=0)]
        public JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequestBody Body;
        
        public SaveApplicantPictureRequest() {
        }
        
        public SaveApplicantPictureRequest(JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveApplicantPictureRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] byteArray;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string applicantId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string urlSender;
        
        public SaveApplicantPictureRequestBody() {
        }
        
        public SaveApplicantPictureRequestBody(byte[] byteArray, string applicantId, string urlSender) {
            this.byteArray = byteArray;
            this.applicantId = applicantId;
            this.urlSender = urlSender;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveApplicantPictureResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveApplicantPictureResponse", Namespace="http://tempuri.org/", Order=0)]
        public JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureResponseBody Body;
        
        public SaveApplicantPictureResponse() {
        }
        
        public SaveApplicantPictureResponse(JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveApplicantPictureResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SaveApplicantPictureResult;
        
        public SaveApplicantPictureResponseBody() {
        }
        
        public SaveApplicantPictureResponseBody(string SaveApplicantPictureResult) {
            this.SaveApplicantPictureResult = SaveApplicantPictureResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface JobRecruitmentWebServiceSoapChannel : JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobRecruitmentWebServiceSoapClient : System.ServiceModel.ClientBase<JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoap>, JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoap {
        
        public JobRecruitmentWebServiceSoapClient() {
        }
        
        public JobRecruitmentWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobRecruitmentWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobRecruitmentWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobRecruitmentWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureResponse JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoap.SaveApplicantPicture(JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequest request) {
            return base.Channel.SaveApplicantPicture(request);
        }
        
        public string SaveApplicantPicture(byte[] byteArray, string applicantId, string urlSender) {
            JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequest inValue = new JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequest();
            inValue.Body = new JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureRequestBody();
            inValue.Body.byteArray = byteArray;
            inValue.Body.applicantId = applicantId;
            inValue.Body.urlSender = urlSender;
            JobApplicantWebCam.JobRecruitmentService.SaveApplicantPictureResponse retVal = ((JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoap)(this)).SaveApplicantPicture(inValue);
            return retVal.Body.SaveApplicantPictureResult;
        }
    }
}
