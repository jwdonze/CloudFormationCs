using System;

namespace CloudFormationCs.Resources.IAM
{
    public class ActionsFormatter : IAwsCustomFormatter
    {
        public Object FormatForAws(Object input)
        {
            return CfnHelpers.GetPolicyName((Resources.IAM.PolicyDocumentStatementActions)input);
        }
    }
    [EmitAsStringAttribute(typeof(ActionsFormatter))]
    public enum PolicyDocumentStatementActions
    {
        /// <summary>
        /// Everything
        /// </summary>
        STAR,

        #region AUTOSCALING
        autoscaling_STAR,
        autoscaling_DescribeSTAR,
        #endregion

        #region CLOUDFORMATION
        cloudFormation_STAR,
        cloudformation_DescribeStacks,
        cloudformation_DescribeStackResource,
        CloudFormation_DescribeStackResource,
        cloudformation_DescribeStackEvents,
        cloudformation_DescribeStackResources,
        cloudformation_GetTemplate,
        cloudformation_UpdateStack,
        #endregion

        #region CLOUDFRONT
        cloudfront_GetSTAR,
        cloudfront_ListSTAR,
        #endregion

        #region CLOUDWATCH
        cloudwatch_STAR,
        cloudwatch_DeleteAlarms,
        cloudwatch_DescribeAlarmHistory,
        cloudwatch_DescribeAlarms,
        cloudwatch_DescribeAlarmsForMetric,
        cloudwatch_DescribeSTAR,
        cloudwatch_ListSTAR,
        cloudwatch_ListMetrics,
        cloudwatch_GetSTAR,
        cloudwatch_GetMetricStatistics,
        cloudwatch_PutMetricAlarm,
        #endregion

        #region DIRECTCONNECT
        directconnect_DescribeSTAR,
        #endregion

        #region DYNAMODB
        dynamodb_STAR,
        dynamodb_GetItem,
        dynamodb_BatchGetItem,
        dynamodb_Query,
        dynamodb_Scan,Undefined,
        dynamodb_DescribeTable,
        dynamodb_ListTables,
        #endregion

        #region EC2
        ec2_STAR,
        ec2_DescribeSTAR,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AcceptVpcPeeringConnection.html
        ///</summary>
        ec2_AcceptVpcPeeringConnection,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AllocateAddress.html
        ///</summary>
        ec2_AllocateAddress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AssignPrivateIpAddresses.html
        ///</summary>
        ec2_AssignPrivateIpAddresses,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AssociateAddress.html
        ///</summary>
        ec2_AssociateAddress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AssociateDhcpOptions.html
        ///</summary>
        ec2_AssociateDhcpOptions,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AssociateRouteTable.html
        ///</summary>
        ec2_AssociateRouteTable,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AttachInternetGateway.html
        ///</summary>
        ec2_AttachInternetGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AttachNetworkInterface.html
        ///</summary>
        ec2_AttachNetworkInterface,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AttachVolume.html
        ///</summary>
        ec2_AttachVolume,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AttachVpnGateway.html
        ///</summary>
        ec2_AttachVpnGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AuthorizeSecurityGroupEgress.html
        ///</summary>
        ec2_AuthorizeSecurityGroupEgress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-AuthorizeSecurityGroupIngress.html
        ///</summary>
        ec2_AuthorizeSecurityGroupIngress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-BundleInstance.html
        ///</summary>
        ec2_BundleInstance,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CancelBundleTask.html
        ///</summary>
        ec2_CancelBundleTask,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CancelConversionTask.html
        ///</summary>
        ec2_CancelConversionTask,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CancelExportTask.html
        ///</summary>
        ec2_CancelExportTask,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CancelReservedInstancesListing.html
        ///</summary>
        ec2_CancelReservedInstancesListing,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CancelSpotInstanceRequests.html
        ///</summary>
        ec2_CancelSpotInstanceRequests,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ConfirmProductInstance.html
        ///</summary>
        ec2_ConfirmProductInstance,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CopyImage.html
        ///</summary>
        ec2_CopyImage,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CopySnapshot.html
        ///</summary>
        ec2_CopySnapshot,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateCustomerGateway.html
        ///</summary>
        ec2_CreateCustomerGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateDhcpOptions.html
        ///</summary>
        ec2_CreateDhcpOptions,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateImage.html
        ///</summary>
        ec2_CreateImage,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateInstanceExportTask.html
        ///</summary>
        ec2_CreateInstanceExportTask,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateInternetGateway.html
        ///</summary>
        ec2_CreateInternetGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateKeyPair.html
        ///</summary>
        ec2_CreateKeyPair,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateNetworkAcl.html
        ///</summary>
        ec2_CreateNetworkAcl,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateNetworkAclEntry.html
        ///</summary>
        ec2_CreateNetworkAclEntry,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateNetworkInterface.html
        ///</summary>
        ec2_CreateNetworkInterface,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreatePlacementGroup.html
        ///</summary>
        ec2_CreatePlacementGroup,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateReservedInstancesListing.html
        ///</summary>
        ec2_CreateReservedInstancesListing,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateRoute.html
        ///</summary>
        ec2_CreateRoute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateRouteTable.html
        ///</summary>
        ec2_CreateRouteTable,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateSecurityGroup.html
        ///</summary>
        ec2_CreateSecurityGroup,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateSnapshot.html
        ///</summary>
        ec2_CreateSnapshot,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateSpotDatafeedSubscription.html
        ///</summary>
        ec2_CreateSpotDatafeedSubscription,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateSubnet.html
        ///</summary>
        ec2_CreateSubnet,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateTags.html
        ///</summary>
        ec2_CreateTags,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVolume.html
        ///</summary>
        ec2_CreateVolume,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpc.html
        ///</summary>
        ec2_CreateVpc,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpcPeeringConnection.html
        ///</summary>
        ec2_CreateVpcPeeringConnection,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnConnection.html
        ///</summary>
        ec2_CreateVpnConnection,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnConnectionRoute.html
        ///</summary>
        ec2_CreateVpnConnectionRoute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html
        ///</summary>
        ec2_CreateVpnGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteCustomerGateway.html
        ///</summary>
        ec2_DeleteCustomerGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteDhcpOptions.html
        ///</summary>
        ec2_DeleteDhcpOptions,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteInternetGateway.html
        ///</summary>
        ec2_DeleteInternetGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteKeyPair.html
        ///</summary>
        ec2_DeleteKeyPair,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteNetworkAcl.html
        ///</summary>
        ec2_DeleteNetworkAcl,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteNetworkAclEntry.html
        ///</summary>
        ec2_DeleteNetworkAclEntry,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteNetworkInterface.html
        ///</summary>
        ec2_DeleteNetworkInterface,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeletePlacementGroup.html
        ///</summary>
        ec2_DeletePlacementGroup,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteRoute.html
        ///</summary>
        ec2_DeleteRoute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteRouteTable.html
        ///</summary>
        ec2_DeleteRouteTable,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteSecurityGroup.html
        ///</summary>
        ec2_DeleteSecurityGroup,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteSnapshot.html
        ///</summary>
        ec2_DeleteSnapshot,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteSpotDatafeedSubscription.html
        ///</summary>
        ec2_DeleteSpotDatafeedSubscription,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteSubnet.html
        ///</summary>
        ec2_DeleteSubnet,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteTags.html
        ///</summary>
        ec2_DeleteTags,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteVolume.html
        ///</summary>
        ec2_DeleteVolume,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteVpc.html
        ///</summary>
        ec2_DeleteVpc,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteVpcPeeringConnection.html
        ///</summary>
        ec2_DeleteVpcPeeringConnection,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteVpnConnection.html
        ///</summary>
        ec2_DeleteVpnConnection,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteVpnConnectionRoute.html
        ///</summary>
        ec2_DeleteVpnConnectionRoute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeleteVpnGateway.html
        ///</summary>
        ec2_DeleteVpnGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DeregisterImage.html
        ///</summary>
        ec2_DeregisterImage,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeAccountAttributes.html
        ///</summary>
        ec2_DescribeAccountAttributes,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeAddresses.html
        ///</summary>
        ec2_DescribeAddresses,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeAvailabilityZones.html
        ///</summary>
        ec2_DescribeAvailabilityZones,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeBundleTasks.html
        ///</summary>
        ec2_DescribeBundleTasks,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeConversionTasks.html
        ///</summary>
        ec2_DescribeConversionTasks,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeCustomerGateways.html
        ///</summary>
        ec2_DescribeCustomerGateways,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeDhcpOptions.html
        ///</summary>
        ec2_DescribeDhcpOptions,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeExportTasks.html
        ///</summary>
        ec2_DescribeExportTasks,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeImageAttribute.html
        ///</summary>
        ec2_DescribeImageAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeImages.html
        ///</summary>
        ec2_DescribeImages,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeInstanceAttribute.html
        ///</summary>
        ec2_DescribeInstanceAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeInstances.html
        ///</summary>
        ec2_DescribeInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeInstanceStatus.html
        ///</summary>
        ec2_DescribeInstanceStatus,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeInternetGateways.html
        ///</summary>
        ec2_DescribeInternetGateways,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeKeyPairs.html
        ///</summary>
        ec2_DescribeKeyPairs,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeNetworkAcls.html
        ///</summary>
        ec2_DescribeNetworkAcls,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeNetworkInterfaceAttribute.html
        ///</summary>
        ec2_DescribeNetworkInterfaceAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeNetworkInterfaces.html
        ///</summary>
        ec2_DescribeNetworkInterfaces,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribePlacementGroups.html
        ///</summary>
        ec2_DescribePlacementGroups,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeRegions.html
        ///</summary>
        ec2_DescribeRegions,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeReservedInstances.html
        ///</summary>
        ec2_DescribeReservedInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeReservedInstancesListings.html
        ///</summary>
        ec2_DescribeReservedInstancesListings,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeReservedInstancesModifications.html
        ///</summary>
        ec2_DescribeReservedInstancesModifications,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeReservedInstancesOfferings.html
        ///</summary>
        ec2_DescribeReservedInstancesOfferings,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeRouteTables.html
        ///</summary>
        ec2_DescribeRouteTables,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSecurityGroups.html
        ///</summary>
        ec2_DescribeSecurityGroups,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshotAttribute.html
        ///</summary>
        ec2_DescribeSnapshotAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html
        ///</summary>
        ec2_DescribeSnapshots,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSpotDatafeedSubscription.html
        ///</summary>
        ec2_DescribeSpotDatafeedSubscription,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSpotInstanceRequests.html
        ///</summary>
        ec2_DescribeSpotInstanceRequests,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSpotPriceHistory.html
        ///</summary>
        ec2_DescribeSpotPriceHistory,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSubnets.html
        ///</summary>
        ec2_DescribeSubnets,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeTags.html
        ///</summary>
        ec2_DescribeTags,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVolumeAttribute.html
        ///</summary>
        ec2_DescribeVolumeAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVolumes.html
        ///</summary>
        ec2_DescribeVolumes,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVolumeStatus.html
        ///</summary>
        ec2_DescribeVolumeStatus,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVpcAttribute.html
        ///</summary>
        ec2_DescribeVpcAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVpcPeeringConnections.html
        ///</summary>
        ec2_DescribeVpcPeeringConnections,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVpcs.html
        ///</summary>
        ec2_DescribeVpcs,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVpnConnections.html
        ///</summary>
        ec2_DescribeVpnConnections,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVpnGateways.html
        ///</summary>
        ec2_DescribeVpnGateways,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DetachInternetGateway.html
        ///</summary>
        ec2_DetachInternetGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DetachNetworkInterface.html
        ///</summary>
        ec2_DetachNetworkInterface,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DetachVolume.html
        ///</summary>
        ec2_DetachVolume,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DetachVpnGateway.html
        ///</summary>
        ec2_DetachVpnGateway,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DisableVgwRoutePropagation.html
        ///</summary>
        ec2_DisableVgwRoutePropagation,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DisassociateAddress.html
        ///</summary>
        ec2_DisassociateAddress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DisassociateRouteTable.html
        ///</summary>
        ec2_DisassociateRouteTable,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-EnableVgwRoutePropagation.html
        ///</summary>
        ec2_EnableVgwRoutePropagation,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-EnableVolumeIO.html
        ///</summary>
        ec2_EnableVolumeIO,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-GetConsoleOutput.html
        ///</summary>
        ec2_GetConsoleOutput,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-GetPasswordData.html
        ///</summary>
        ec2_GetPasswordData,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ImportInstance.html
        ///</summary>
        ec2_ImportInstance,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ImportKeyPair.html
        ///</summary>
        ec2_ImportKeyPair,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ImportVolume.html
        ///</summary>
        ec2_ImportVolume,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifyImageAttribute.html
        ///</summary>
        ec2_ModifyImageAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifyInstanceAttribute.html
        ///</summary>
        ec2_ModifyInstanceAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifyNetworkInterfaceAttribute.html
        ///</summary>
        ec2_ModifyNetworkInterfaceAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifyReservedInstances.html
        ///</summary>
        ec2_ModifyReservedInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifySnapshotAttribute.html
        ///</summary>
        ec2_ModifySnapshotAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifyVolumeAttribute.html
        ///</summary>
        ec2_ModifyVolumeAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ModifyVpcAttribute.html
        ///</summary>
        ec2_ModifyVpcAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-MonitorInstances.html
        ///</summary>
        ec2_MonitorInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-PurchaseReservedInstancesOffering.html
        ///</summary>
        ec2_PurchaseReservedInstancesOffering,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RebootInstances.html
        ///</summary>
        ec2_RebootInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RegisterImage.html
        ///</summary>
        ec2_RegisterImage,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RejectVpcPeeringConnection.html
        ///</summary>
        ec2_RejectVpcPeeringConnection,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ReleaseAddress.html
        ///</summary>
        ec2_ReleaseAddress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ReplaceNetworkAclAssociation.html
        ///</summary>
        ec2_ReplaceNetworkAclAssociation,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ReplaceNetworkAclEntry.html
        ///</summary>
        ec2_ReplaceNetworkAclEntry,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ReplaceRoute.html
        ///</summary>
        ec2_ReplaceRoute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ReplaceRouteTableAssociation.html
        ///</summary>
        ec2_ReplaceRouteTableAssociation,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ReportInstanceStatus.html
        ///</summary>
        ec2_ReportInstanceStatus,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RequestSpotInstances.html
        ///</summary>
        ec2_RequestSpotInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ResetImageAttribute.html
        ///</summary>
        ec2_ResetImageAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ResetInstanceAttribute.html
        ///</summary>
        ec2_ResetInstanceAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ResetNetworkInterfaceAttribute.html
        ///</summary>
        ec2_ResetNetworkInterfaceAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-ResetSnapshotAttribute.html
        ///</summary>
        ec2_ResetSnapshotAttribute,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RevokeSecurityGroupEgress.html
        ///</summary>
        ec2_RevokeSecurityGroupEgress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RevokeSecurityGroupIngress.html
        ///</summary>
        ec2_RevokeSecurityGroupIngress,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-RunInstances.html
        ///</summary>
        ec2_RunInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-StartInstances.html
        ///</summary>
        ec2_StartInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-StopInstances.html
        ///</summary>
        ec2_StopInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-TerminateInstances.html
        ///</summary>
        ec2_TerminateInstances,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-UnassignPrivateIpAddresses.html
        ///</summary>
        ec2_UnassignPrivateIpAddresses,

        ///<summary>
        /// http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-UnmonitorInstances.html
        ///</summary>
        ec2_UnmonitorInstances,
        #endregion EC2

        #region elasticache
        elasticache_DescribeSTAR,
        #endregion

        #region ElasticBeanstalk
        elasticbeanstalk_STAR,
        elasticbeanstalk_CheckSTAR,
        elasticbeanstalk_DescribeSTAR,
        elasticbeanstalk_ListSTAR,
        elasticbeanstalk_RequestEnvironmentInfo,
        elasticbeanstalk_RetrieveEnvironmentInfo,
        #endregion

        #region ELB
        elasticloadbalancing_STAR,
        elasticloadbalancing_AddTags,
        elasticloadbalancing_ApplySecurityGroupsToLoadBalancer,
        elasticloadbalancing_AttachLoadBalancerToSubnets,
        elasticloadbalancing_ConfigureHealthCheck,
        elasticloadbalancing_CreateAppCookieStickinessPolicy,
        elasticloadbalancing_CreateLBCookieStickinessPolicy,
        elasticloadbalancing_CreateLoadBalancer,
        elasticloadbalancing_CreateLoadBalancerListeners,
        elasticloadbalancing_CreateLoadBalancerPolicy,
        elasticloadbalancing_DeleteLoadBalancer,
        elasticloadbalancing_DeleteLoadBalancerListeners,
        elasticloadbalancing_DeleteLoadBalancerPolicy,
        elasticloadbalancing_DeregisterInstancesFromLoadBalancer,
        elasticloadbalancing_DescribeSTAR,
        elasticloadbalancing_DescribeInstanceHealth,
        elasticloadbalancing_DescribeLoadBalancerAttributes,
        elasticloadbalancing_DescribeLoadBalancerPolicies,
        elasticloadbalancing_DescribeLoadBalancerPolicyTypes,
        elasticloadbalancing_DescribeLoadBalancers,
        elasticloadbalancing_DescribeTags,
        elasticloadbalancing_DetachLoadBalancerFromSubnets,
        elasticloadbalancing_DisableAvailabilityZonesForLoadBalancer,
        elasticloadbalancing_EnableAvailabilityZonesForLoadBalancer,
        elasticloadbalancing_ModifyLoadBalancerAttributes,
        elasticloadbalancing_RegisterInstancesWithLoadBalancer,
        elasticloadbalancing_RemoveTags,
        elasticloadbalancing_SetLoadBalancerListenerSSLCertificate,
        elasticloadbalancing_SetLoadBalancerPoliciesForBackendServer,
        elasticloadbalancing_SetLoadBalancerPoliciesOfListener,
        #endregion

        #region elastictranscoder
        elastictranscoder_ReadSTAR,
        elastictranscoder_ListSTAR,
        #endregion

        #region IAM
        iam_STAR,
        iam_GetUser,
        iam_CreateAccessKey,
        iam_ListSTAR,
        iam_GetSTAR,
        #endregion

        #region S3

        // http://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html

        s3_STAR,
        s3_GetSTAR,
        s3_ListSTAR,

        s3_GetObject,
        s3_GetObjectVersion,
        s3_PutObject,
        s3_GetObjectAcl,
        s3_GetObjectVersionAcl,
        s3_PutObjectAcl,
        s3_PutObjectVersionAcl,
        s3_DeleteObject,
        s3_DeleteObjectVersion,
        s3_ListMultipartUploadParts,
        s3_AbortMultipartUpload,
        s3_GetObjectTorrent,
        s3_GetObjectVersionTorrent,
        s3_RestoreObject,
        s3_CreateBucket,
        s3_DeleteBucket,
        s3_ListBucket,
        s3_ListBucketVersions,
        s3_ListAllMyBuckets,
        s3_ListBucketMultipartUploads,
        s3_GetBucketAcl,
        s3_PutBucketAcl,
        s3_GetBucketCORS,
        s3_PutBucketCORS,
        s3_GetBucketVersioning,
        s3_PutBucketVersioning,
        s3_GetBucketRequestPayment,
        s3_PutBucketRequestPayment,
        s3_GetBucketLocation,
        s3_GetBucketPolicy,
        s3_DeleteBucketPolicy,
        s3_PutBucketPolicy,
        s3_GetBucketNotification,
        s3_PutBucketNotification,
        s3_GetBucketLogging,
        s3_PutBucketLogging,
        s3_GetBucketTagging ,
        s3_PutBucketTagging ,
        s3_GetBucketWebsite,
        s3_PutBucketWebsite,
        s3_DeleteBucketWebsite,
        s3_GetLifecycleConfiguration,
        s3_PutLifecycleConfiguration,

        #endregion

        #region Route 53
        route53_STAR,
        route53_ChangeResourceRecordSets,
        route53_ListResourceRecordSets,
        route53_GetSTAR,
        route53_GetChange,
        route53_GetGeoLocation,
        route53_GetHostedZone,
        route53_ListSTAR,
        route53_ListGeoLocations,
        route53_ListHostedZones,
        route53_CreateHostedZone,
        route53_DeleteHostedZone,
        #endregion

        sts_AssumeRole,

        #region SQS
        sqs_STAR,
        sqs_SendMessage,
        sqs_ReceiveMessage,
        sqs_ChangeMessageVisibility,
        sqs_DeleteMessage,
        sqs_GetQueueAttributes,
        sqs_GetQueueUrl,
        sqs_CreateQueue,
        sqs_DeleteQueue,
        sqs_ListQueues,
        #endregion

        #region SNS
        sns_STAR,
        sns_CreateTopic,
        sns_ListSubscriptionsByTopic,
        sns_ListTopics,
        sns_Publish,
        sns_Subscribe,
        sns_Unsubscribe,
        sns_GetSTAR,
        sns_ListSTAR,
        #endregion









        redshift_DescribeSTAR,
        redshift_ViewQueriesInConsole,

        #region RDS
        rds_STAR,
        rds_DescribeSTAR,
        rds_ListTagsForResource,
        #endregion

        #region SDB
        sdb_GetAttributes,
        sdb_ListSTAR,
        sdb_SelectSTAR,
        #endregion

        #region SES
        ses_GetSTAR,
        ses_ListSTAR,
        #endregion

        storagegateway_ListSTAR,
        storagegateway_DescribeSTAR,

    }
}
