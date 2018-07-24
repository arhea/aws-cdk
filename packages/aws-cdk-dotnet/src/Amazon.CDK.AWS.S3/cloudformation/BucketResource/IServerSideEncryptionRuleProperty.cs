using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html </remarks>
    [JsiiInterface(typeof(IServerSideEncryptionRuleProperty), "@aws-cdk/aws-s3.cloudformation.BucketResource.ServerSideEncryptionRuleProperty")]
    public interface IServerSideEncryptionRuleProperty
    {
        /// <summary>``BucketResource.ServerSideEncryptionRuleProperty.ServerSideEncryptionByDefault``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-serversideencryptionbydefault </remarks>
        [JsiiProperty("serverSideEncryptionByDefault", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.ServerSideEncryptionByDefaultProperty\"}]},\"optional\":true}")]
        object ServerSideEncryptionByDefault
        {
            get;
            set;
        }
    }
}