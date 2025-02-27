/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAccessPointConfigurationForObjectLambda Request Marshaller
    /// </summary>       
    public class PutAccessPointConfigurationForObjectLambdaRequestMarshaller : IMarshaller<IRequest, PutAccessPointConfigurationForObjectLambdaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAccessPointConfigurationForObjectLambdaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAccessPointConfigurationForObjectLambdaRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetName())
                throw new AmazonS3ControlException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v20180820/accesspointforobjectlambda/{name}/configuration";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("PutAccessPointConfigurationForObjectLambdaRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                
                if (publicRequest.Configuration != null) 
                {
                    xmlWriter.WriteStartElement("Configuration", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    var publicRequestConfigurationAllowedFeatures = publicRequest.Configuration.AllowedFeatures;
                    if (publicRequestConfigurationAllowedFeatures != null && publicRequestConfigurationAllowedFeatures.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("AllowedFeatures", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                        foreach (var publicRequestConfigurationAllowedFeaturesValue in publicRequestConfigurationAllowedFeatures) 
                        {
                            xmlWriter.WriteStartElement("AllowedFeature", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            xmlWriter.WriteValue(publicRequestConfigurationAllowedFeaturesValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.Configuration.IsSetCloudWatchMetricsEnabled())
                        xmlWriter.WriteElementString("CloudWatchMetricsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Configuration.CloudWatchMetricsEnabled));                 
    
                    if(publicRequest.Configuration.IsSetSupportingAccessPoint())
                        xmlWriter.WriteElementString("SupportingAccessPoint", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Configuration.SupportingAccessPoint));                 
    
                    var publicRequestConfigurationTransformationConfigurations = publicRequest.Configuration.TransformationConfigurations;
                    if (publicRequestConfigurationTransformationConfigurations != null && publicRequestConfigurationTransformationConfigurations.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("TransformationConfigurations", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                        foreach (var publicRequestConfigurationTransformationConfigurationsValue in publicRequestConfigurationTransformationConfigurations) 
                        {
                        
                        if (publicRequestConfigurationTransformationConfigurationsValue != null) 
                        {
                            xmlWriter.WriteStartElement("TransformationConfiguration", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            var publicRequestConfigurationTransformationConfigurationsValueActions = publicRequestConfigurationTransformationConfigurationsValue.Actions;
                            if (publicRequestConfigurationTransformationConfigurationsValueActions != null && publicRequestConfigurationTransformationConfigurationsValueActions.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Actions", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                foreach (var publicRequestConfigurationTransformationConfigurationsValueActionsValue in publicRequestConfigurationTransformationConfigurationsValueActions) 
                                {
                                    xmlWriter.WriteStartElement("Action", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                    xmlWriter.WriteValue(publicRequestConfigurationTransformationConfigurationsValueActionsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            
                            if (publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation != null) 
                            {
                                xmlWriter.WriteStartElement("ContentTransformation", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                
                                if (publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda != null) 
                                {
                                    xmlWriter.WriteStartElement("AwsLambda", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.IsSetFunctionArn())
                                        xmlWriter.WriteElementString("FunctionArn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.FunctionArn));                 
                    
                                    if(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.IsSetFunctionPayload())
                                        xmlWriter.WriteElementString("FunctionPayload", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.FunctionPayload));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }


            var hostPrefixLabels = new
            {
                AccountId = StringUtils.FromString(publicRequest.AccountId),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.AccountId))
                throw new AmazonS3ControlException("AccountId can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.AccountId}.";
            return request;
        }
        private static PutAccessPointConfigurationForObjectLambdaRequestMarshaller _instance = new PutAccessPointConfigurationForObjectLambdaRequestMarshaller();        

        internal static PutAccessPointConfigurationForObjectLambdaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAccessPointConfigurationForObjectLambdaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}