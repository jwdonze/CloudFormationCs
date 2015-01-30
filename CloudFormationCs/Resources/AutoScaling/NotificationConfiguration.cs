using System;

namespace CloudFormationCs.Resources.AutoScaling
{
    public class NotificationConfiguration
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic.
        /// </summary>
        [Required(true)]
        public StringRef TopicARN { get; set; }

        /// <summary>
        /// The type of events that will trigger the notification. 
        /// </summary>
        /// <value>
        /// A list of events that will trigger the notification, 
        /// which can include any or all of the following: 
        /// 	autoscaling:EC2_INSTANCE_LAUNCH, 
        /// 	autoscaling:EC2_INSTANCE_LAUNCH_ERROR, 
        /// 	autoscaling:EC2_INSTANCE_TERMINATE, 
        /// 	autoscaling:EC2_INSTANCE_TERMINATE_ERROR, and 
        /// 	autoscaling:TEST_NOTIFICATION. 
        /// 
        /// For more information about event types, see DescribeAutoScalingNotificationTypes.
        /// </value>
        [Required(true)]
        public String[] NotificationTypes { get; set; }
    }
}
