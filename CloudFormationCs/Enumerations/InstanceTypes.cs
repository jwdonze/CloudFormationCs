using System;

namespace CloudFormationCs
{
	public enum InstanceTypes
	{
        Undefined,
        t2_micro,
        t2_small,
        t2_medium,

		//Instance Family   Instance Type 	Processor Arch 	vCPU 	ECU 	Memory (GiB) 	Instance Storage (GB) 	EBS-optimized Available 	Network Performance
		/// <summary>
		/// General purpose 	m3.medium 	64-bit 	1 	3 	3.75 	1 x 4 SSD*6 	- 	Moderate
		/// </summary>
		m3_medium,

		/// <summary>
		/// General purpose  	m3.large 	64-bit 	2 	6.5 	7.5 	1 x 32 SSD*6 	- 	Moderate
		/// </summary>
		m3_large,

		/// <summary>
		/// General purpose  	m3.xlarge 	64-bit 	4 	13 	15 	2 x 40 SSD*6 	Yes 	High
		/// </summary>
		m3_xlarge,

		/// <summary>
		/// General purpose  	m3.2xlarge 	64-bit 	8 	26 	30 	2 x 80 SSD*6 	Yes 	High
		/// </summary>
		m3_2xlarge,

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
		/// Compute optimized 	c3.large 	64-bit 	2 	7 	3.75 	2 x 16 SSD 	- 	Moderate
		/// </summary>
		c3_large,

		/// <summary>
		/// Compute optimized 	c3.xlarge 	64-bit 	4 	14 	7.5 	2 x 40 SSD 	Yes 	Moderate
		/// </summary>
		c3_xlarge,

		/// <summary>
		/// Compute optimized 	c3.2xlarge 	64-bit 	8 	28 	15 	2 x 80 SSD 	Yes 	High
		/// </summary>
		c3_2xlarge,

		/// <summary>
		/// Compute optimized 	c3.4xlarge 	64-bit 	16 	55 	30 	2 x 160 SSD 	Yes 	High
		/// </summary>
		c3_4xlarge,

		/// <summary>
		/// Compute optimized 	c3.8xlarge 	64-bit 	32 	108 	60 	2 x 320 SSD 	- 	10 Gigabit*4
		/// </summary>
		c3_8xlarge,

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
		cc2_8xlarge,

		/// <summary>
		/// GPU instances 	g2.2xlarge 	64-bit 	8 	26 	15 	1 x 60 SSD 	Yes 	High
		/// </summary>
		g2_2xlarge,

		/// <summary>
		/// GPU instances 	cg1.4xlarge 	64-bit 	16 	33.5 	22.5 	2 x 840 	- 	10 Gigabit*4
		/// </summary>
		cg1_4xlarge,

		/// <summary>
		/// Memory optimized 	r3.large 	64-bit 	2 	6.5 	15 	1 x 32 SSD 	- 	Moderate
		/// </summary>
		r3_large,

		/// <summary>
		/// Memory optimized 	r3.xlarge 	64-bit 	4 	13 	30.5 	1 x 80 SSD 	Yes 	Moderate
		/// </summary>
		r3_xlarge,

		/// <summary>
		/// Memory optimized 	r3.2xlarge 	64-bit 	8 	26 	61 	1 x 160 SSD 	Yes 	High
		/// </summary>
		r3_2xlarge,

		/// <summary>
		/// Memory optimized 	r3.4xlarge 	64-bit 	16 	52 	122 	1 x 320 SSD 	Yes 	High
		/// </summary>
		r3_4xlarge,

		/// <summary>
		/// Memory optimized 	r3.8xlarge 	64-bit 	32 	104 	244 	2 x 320 SSD 	- 	10 Gigabit*4
		/// </summary>
		r3_8xlarge,

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
		cr1_8xlarge,

		/// <summary>
		/// Storage optimized 	i2.xlarge 	64-bit 	4 	14 	30.5 	1 x 800 SSD 	Yes 	Moderate
		/// </summary>
		i2_xlarge,

		/// <summary>
		/// Storage optimized 	i2.2xlarge 	64-bit 	8 	27 	61 	2 x 800 SSD 	Yes 	High
		/// </summary>
		i2_2xlarge,

		/// <summary>
		/// Storage optimized 	i2.4xlarge 	64-bit 	16 	53 	122 	4 x 800 SSD 	Yes 	High
		/// </summary>
		i2_4xlarge,

		/// <summary>
		/// Storage optimized 	i2.8xlarge 	64-bit 	32 	104 	244 	8 x 800 SSD 	- 	10 Gigabit*4
		/// </summary>
		i2_8xlarge,

		/// <summary>
		/// Storage optimized 	hs1.8xlarge 	64-bit 	16 	35 	117 	24 x 2,048*3 	- 	10 Gigabit*4
		/// </summary>
		hs1_8xlarge,                                                                     

		/// <summary>
		/// Storage optimized 	hi1.4xlarge 	64-bit 	16 	35 	60.5 	2 x 1,024
		/// SSD*2 	- 	10 Gigabit*4
		/// </summary>
		hi1_4xlarge,                                                                    

		/// <summary>
		/// Micro instances 	t1.micro 	32-bit or
		/// 64-bit 	1 	Variable*5 	0.615 	EBS only 	- 	Very Low
		/// </summary>
        [Obsolete]
		t1_micro, 
	}
}

