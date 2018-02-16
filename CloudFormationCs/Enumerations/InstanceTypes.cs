using System;

namespace CloudFormationCs
{
    /// <summary>
    /// https://aws.amazon.com/ec2/instance-types/
    /// </summary>
	public enum InstanceTypes
	{
        Undefined,

        /// <summary>
        /// 1 CPU, .6 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_nano,
        /// <summary>
        /// 1 CPU, 1 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_micro,
        /// <summary>
        /// 1 CPU, 2 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_small,
        /// <summary>
        /// 2 CPU, 4 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_medium,
        /// <summary>
        /// 2 CPU, 8 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_large,
        /// <summary>
        /// 4 CPU, 16 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_xlarge,
        /// <summary>
        /// 8 CPU, 32 GiB RAM, EBS Only, Low to Moderate Net
        /// </summary>
        t2_2xlarge,

        /// <summary>
        /// 2 CPU, 8 GiB RAM, ebsonly
        /// </summary>
        m5_large,
        /// <summary>
        /// 4 CPU, 16 GiB RAM, ebsonly
        /// </summary>
        m5_xlarge,
        /// <summary>
        /// 8 CPU, 32 GiB RAM, ebsonly
        /// </summary>
        m5_2xlarge,
        /// <summary>
        /// 16 CPU, 64 GiB RAM, ebsonly
        /// </summary>
        m5_4xlarge,
        /// <summary>
        /// 48 CPU, 192 GiB RAM, ebsonly
        /// </summary>
        m5_12xlarge,
        /// <summary>
        /// 96 CPU, 384 GiB RAM, ebsonly
        /// </summary>
        m5_24xlarge,

        /// <summary>
        /// 2 CPU, 8 GiB RAM, EBS Only, Moderate Net, 450 Mbps EBS
        /// </summary>
        m4_large,

        /// <summary>
        /// 4 CPU, 16 GiB RAM, EBS Only, High Net, 750 Mbps EBS
        /// </summary>
        m4_xlarge,

        /// <summary>
        /// 8 CPU, 32 GiB RAM, EBS Only, High Net, 1,000 Mbps EBS
        /// </summary>
        m4_2xlarge,

        /// <summary>
        /// 16 CPU, 64 GiB RAM, EBS Only, High Net, 2,000 Mbps EBS
        /// </summary>
        m4_4xlarge,

        /// <summary>
        /// 40 CPU, 160 GiB RAM, EBS Only, 10 Gbps Net, 4,000 Mbps EBS
        /// </summary>
        m4_10xlarge,



		/// <summary>
        /// 1 CPU, 3.75 GiB RAM, 1 x 4 SSD, Moderate Net
		/// </summary>
		m3_medium,

		/// <summary>
        /// 2 CPU, 7.5 GiB RAM, 1 x 32 SSD, Moderate Net
		/// </summary>
		m3_large,

		/// <summary>
		/// 4 CPU, 15 GiB RAM, 2 x 40 SSD, High Net
		/// </summary>
		m3_xlarge,

		/// <summary>
		/// 8 CPU, 30 GiB RAM, 2 x 80 SSD, High Net
		/// </summary>
		m3_2xlarge,



        /// <summary>
        /// 2 CPU, 3.75 GiB RAM, EBS Only, Moderate Net, 500 Mbps EBS
        /// </summary>
        c4_large,

        /// <summary>
        /// 4 CPU, 7.5 GiB RAM, EBS Only, Moderate Net, 750 Mbps EBS
        /// </summary>
        c4_xlarge,

        /// <summary>
        /// 8 CPU, 15 GiB RAM, EBS Only, High Net, 1,000 Mbps EBS
        /// </summary>
        c4_2xlarge,

        /// <summary>
        /// 16 CPU, 30 GiB RAM, EBS Only, High Net, 2,000 Mbps EBS
        /// </summary>
        c4_4xlarge,

        /// <summary>
        /// 36 CPU, 60 GiB RAM, EBS Only, 10 Gbps Net, 4,000 Mbps EBS
        /// </summary>
        c4_8xlarge,



		/// <summary>
		/// 2 CPU, 3.75 GiB RAM, 2 x 16 SSD, Moderate Net
		/// </summary>
		c3_large,

		/// <summary>
		/// 4 CPU, 7.5 GiB RAM, 2 x 40 SSD, Moderate Net
		/// </summary>
		c3_xlarge,

		/// <summary>
		/// 8 CPU, 15 GiB RAM, 2 x 80 SSD, High Net
		/// </summary>
		c3_2xlarge,

		/// <summary>
		/// 16 CPU, 30 GiB RAM, 2 x 160 SSD, High Net
		/// </summary>
		c3_4xlarge,

		/// <summary>
		/// 32 CPU, 60 GiB RAM, 2 x 320 SSD, 10 Gigabit Net
		/// </summary>
		c3_8xlarge,



        /// <summary>
        /// 8 CPU, 15 GiB RAM, 1 x 60 SSD, High Net
        /// </summary>
        g2_2xlarge,

        /// <summary>
        /// 32 CPU, 60 GiB RAM, 2 x 120 SSD, 10 Gigabit Net
        /// </summary>
        g2_8xlarge,

        /// <summary>
        /// 64 CPU 	976   GiB RAM, 1 x 1,920 SSD 	10 Gigabit  Intel Xeon E7-8880 v3 	2.3
        /// </summary>
        x1_16large,
        /// <summary>
        /// 128 CPU  1,952 GiB RAM, 2 x 1,920 SSD 	20 Gigabit  Intel Xeon E7-8880 v3 	2.3
        /// </summary>
        x1_32xlarge,
        /// <summary>
        /// 2  CPU  15.25 GiB RAM, ELB Only   Up to 10 Gigabit    Intel Xeon E5-2686 v4   2.3
        /// </summary>
        r4_large,
        /// <summary>
        /// 4  CPU  30.5  GiB RAM, ELB Only   Up to 10 Gigabit    Intel Xeon E5-2686 v4   2.3
        /// </summary>
        r4_xlarge,
        /// <summary>
        /// 8  CPU  61    GiB RAM, ELB Only   Up to 10 Gigabit    Intel Xeon E5-2686 v4   2.3
        /// </summary>
        r4_2xlarge,
        /// <summary>
        /// 16 CPU  122   GiB RAM, ELB Only   Up to 10 Gigabit    Intel Xeon E5-2686 v4   2.3
        /// </summary>
        r4_4xlarge,
        /// <summary>
        /// 32 CPU  244   GiB RAM, ELB Only   10 Gigabit  Intel Xeon E5-2686 v4   2.3
        /// </summary>
        r4_8xlarge,
        /// <summary>
        /// 64 CPU  488   GiB RAM, ELB Only   20 Gigabit  Intel Xeon E5-2686 v4   2.3
        /// </summary>
        r4_16xlarge, 


        /// <summary>
        /// 2 CPU, 15.25 GiB RAM, 1 x 32 SSD, Moderate Net  Intel Xeon E5-2670 v2 	2.5
        /// </summary>
        r3_large,

		/// <summary>
        /// 4 CPU, 30.5 GiB RAM, 1 x 80 SSD, Moderate Net  Intel Xeon E5-2670 v2 	2.5
		/// </summary>
		r3_xlarge,

		/// <summary>
        /// 8 CPU, 61 GiB RAM, 1 x 160 SSD, High Net  Intel Xeon E5-2670 v2 	2.5
		/// </summary>
		r3_2xlarge,

		/// <summary>
        /// 16 CPU, 122 GiB RAM, 1 x 320 SSD, High Net  Intel Xeon E5-2670 v2 	2.5
		/// </summary>
		r3_4xlarge,

		/// <summary>
		/// 32 CPU, 244 GiB RAM, 2 x 320 SSD, 10 Gigabit Net  Intel Xeon E5-2670 v2 	2.5
		/// </summary>
		r3_8xlarge,



		/// <summary>
        /// 4 CPU, 30.5 GiB RAM, 1 x 800 SSD, Moderate Net
		/// </summary>
		i2_xlarge,

		/// <summary>
        /// 8 CPU, 61 GiB RAM, 2 x 800 SSD, High Net
		/// </summary>
		i2_2xlarge,

		/// <summary>
        /// 16 CPU, 122 GiB RAM, 4 x 800 SSD, High Net
		/// </summary>
		i2_4xlarge,

		/// <summary>
        /// 32 CPU, 244 GiB RAM, 8 x 800 SSD, 10 Gigabit Net
		/// </summary>
		i2_8xlarge,



        /// <summary>
        /// 4 CPU, 30.5 GiB RAM, 3 x 2000 HDD, Moderate Net
        /// </summary>
        d2_xlarge,
        /// <summary>
        /// 8 CPU, 61 GiB RAM, 6 x 2000 HDD, High Net
        /// </summary>
        d2_2xlarge,
        /// <summary>
        /// 16 CPU, 122 GiB RAM, 12 x 2000 HDD, High Net
        /// </summary>
        d2_4xlarge,
        /// <summary>
        /// 36 CPU, 244 GiB RAM, 24 x 2000 HDD, 10 Gigabit Net
        /// </summary>
        d2_8xlarge,

        /// <summary>
        /// 4  CPU, 61  GiB RAM, EBS Only    High    Intel Xeon E5-2686 v4   2.3 (base)  2.7 (turbo)
        /// </summary>
        p2_xlarge,
        /// <summary>
        /// 32 CPU, 488 GiB RAM, EBS Only    10 Gigabit  Intel Xeon E5-2686 v4   2.3 (base)  2.7 (turbo)
        /// </summary>
        p2_8xlarge,
        /// <summary>
        /// 64 CPU, 732 GiB RAM, EBS Only    20 Gigabit  Intel Xeon E5-2686 v4   2.3 (base)  2.7 (turbo)
        /// </summary>
        p2_16xlarge,
        /// <summary>
        /// 16 CPU,	122 GiB RAM, EBS Only    Up to 10 Gigabit    Intel Xeon E5-2686 v4  	2.3 (base)  2.7 (turbo)
        /// </summary>
        g3_4xlarge,
        /// <summary>
        /// 32 CPU,	244 GiB RAM, EBS Only 	10 Gigabit  Intel Xeon E5-2686 v4  	2.3 (base)  2.7 (turbo)
        /// </summary>
        g3_8xlarge,
        /// <summary>
        /// 64 CPU,	488 GiB RAM, EBS Only 	20 Gigabit  Intel Xeon E5-2686 v4  	2.3 (base)  2.7 (turbo)
        /// </summary>
        g3_16xlarge,
        /// <summary>
        /// 8  CPU, 122 GiB RAM, 480 SSD     Up to 10 Gigabit        Intel Xeon E5-2686 v4 	    2.3 (base)  2.7 (turbo)
        /// </summary>
        f1_2xlarge,
        /// <summary>
        /// 64 CPU,	976 GiB RAM, 4 x 960 	20 Gigabit      Intel Xeon E5-2686 v4 	    2.3 (base)  2.7 (turbo)
        /// </summary>
        f1_16xlarge, 


        #region PREVIOUS GENERATION 
        /// <summary>
        /// General purpose  	m1.small 	32-bit or
        ///   64-bit 	1*1 	1 	1.7 	1 x 160 	- 	Low
        /// </summary>
        [Obsolete]
        m1_small,

        /// <summary>
        /// General purpose 	m1.medium 	32-bit or
        /// 64-bit 	1 	2 	3.75 	1 x 410 	- 	Moderate
        /// </summary>
        [Obsolete]
        m1_medium,

        /// <summary>
        /// General purpose 	m1.large 	64-bit 	2 	4 	7.5 	2 x 420 	Yes 	Moderate
        /// </summary>
        [Obsolete]
        m1_large,

        /// <summary>
        /// General purpose 	m1.xlarge 	64-bit 	4 	8 	15 	4 x 420 	Yes 	High
        /// </summary>
        [Obsolete]
        m1_xlarge,


        /// <summary>
        /// Compute optimized 	c1.medium 	32-bit or
        /// 64-bit 	2 	5 	1.7 	1 x 350 	- 	Moderate
        /// </summary>
        [Obsolete]
        c1_medium,

        /// <summary>
        /// Compute optimized 	c1.xlarge 	64-bit 	8 	20 	7 	4 x 420 	Yes 	High
        /// </summary>
        [Obsolete]
        c1_xlarge,


        /// <summary>
        /// Compute optimized 	cc2.8xlarge 	64-bit 	32 	88 	60.5 	4 x 840 	- 	10 Gigabit*4
        /// </summary>
        [Obsolete]
        cc2_8xlarge,

        /// <summary>
        /// GPU instances 	cg1.4xlarge 	64-bit 	16 	33.5 	22.5 	2 x 840 	- 	10 Gigabit*4
        /// </summary>
        [Obsolete]
        cg1_4xlarge,


        /// <summary>
        /// Memory optimized 	m2.xlarge 	64-bit 	2 	6.5 	17.1 	1 x 420 	- 	Moderate
        /// </summary>
        [Obsolete]
        m2_xlarge,

        /// <summary>
        /// Memory optimized 	m2.2xlarge 	64-bit 	4 	13 	34.2 	1 x 850 	Yes 	Moderate
        /// </summary>
        [Obsolete]
        m2_2xlarge,

        /// <summary>
        /// Memory optimized 	m2.4xlarge 	64-bit 	8 	26 	68.4 	2 x 840 	Yes 	High
        /// </summary>
        [Obsolete]
        m2_4xlarge,

        /// <summary>
        /// Memory optimized 	cr1.8xlarge 	64-bit 	32 	88 	244 	2 x 120
        /// SSD 	- 	10 Gigabit*4
        /// </summary>
        [Obsolete]
        cr1_8xlarge,

        /// <summary>
        /// Storage optimized 	hi1.4xlarge 	64-bit 	16 	35 	60.5 	2 x 1,024
        /// SSD*2 	- 	10 Gigabit*4
        /// </summary>
        [Obsolete]
        hi1_4xlarge,

        /// <summary>
        /// Storage optimized 	hs1.8xlarge 	64-bit 	16 	35 	117 	24 x 2,048*3 	- 	10 Gigabit*4
        /// </summary>
        [Obsolete]
        hs1_8xlarge,


		/// <summary>
		/// Micro instances 	t1.micro 	32-bit or
		/// 64-bit 	1 	Variable*5 	0.615 	EBS only 	- 	Very Low
		/// </summary>
        [Obsolete]
		t1_micro,

        #endregion
    }
}

