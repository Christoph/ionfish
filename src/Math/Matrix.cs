namespace Math
{
    public class Matrix
    {
        // Don't use auto properties because then the 
        // default StructLayout (which is LayoutKind.Sequential for structs) is not guaranteed.
        private readonly float mR1C1;
        private readonly float mR1C2;
        private readonly float mR1C3;
        private readonly float mR1C4;

        private readonly float mR2C1;
        private readonly float mR2C2;
        private readonly float mR2C3;
        private readonly float mR2C4;

        private readonly float mR3C1;
        private readonly float mR3C2;
        private readonly float mR3C3;
        private readonly float mR3C4;

        private readonly float mR4C1;
        private readonly float mR4C2;
        private readonly float mR4C3;
        private readonly float mR4C4;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> struct.
        /// </summary>
        /// <param name="r1c1">The value of the row 1 column 1.</param>
        /// <param name="r1c2">The value of the row 1 column 2.</param>
        /// <param name="r1c3">The value of the row 1 column 3.</param>
        /// <param name="r1c4">The value of the row 1 column 4.</param>
        /// <param name="r2c1">The value of the row 2 column 1.</param>
        /// <param name="r2c2">The value of the row 2 column 2.</param>
        /// <param name="r2c3">The value of the row 2 column 3.</param>
        /// <param name="r2c4">The value of the row 2 column 4.</param>
        /// <param name="r3c1">The value of the row 3 column 1.</param>
        /// <param name="r3c2">The value of the row 3 column 2.</param>
        /// <param name="r3c3">The value of the row 3 column 3.</param>
        /// <param name="r3c4">The value of the row 3 column 4.</param>
        /// <param name="r4c1">The value of the row 4 column 1.</param>
        /// <param name="r4c2">The value of the row 4 column 2.</param>
        /// <param name="r4c3">The value of the row 4 column 3.</param>
        /// <param name="r4c4">The value of the row 4 column 4.</param>
        public Matrix(
            float r1c1, float r1c2, float r1c3, float r1c4,
            float r2c1, float r2c2, float r2c3, float r2c4,
            float r3c1, float r3c2, float r3c3, float r3c4,
            float r4c1, float r4c2, float r4c3, float r4c4)
        {
            mR1C1 = r1c1;
            mR1C2 = r1c2;
            mR1C3 = r1c3;
            mR1C4 = r1c4;

            mR2C1 = r2c1;
            mR2C2 = r2c2;
            mR2C3 = r2c3;
            mR2C4 = r2c4;

            mR3C1 = r3c1;
            mR3C2 = r3c2;
            mR3C3 = r3c3;
            mR3C4 = r3c4;

            mR4C1 = r4c1;
            mR4C2 = r4c2;
            mR4C3 = r4c3;
            mR4C4 = r4c4;
        }

        /// <summary>
        /// Gets the value of row 1 column 1.
        /// </summary>
        /// <value>The value of row 1 column 1.</value>
        public float R1C1
        {
            get { return mR1C1; }
        }

        /// <summary>
        /// Gets the value of row 1 column 2.
        /// </summary>
        /// <value>The value of row 1 column 2.</value>
        public float R1C2
        {
            get { return mR1C2; }
        }

        /// <summary>
        /// Gets the value of row 1 column 3.
        /// </summary>
        /// <value>The value of row 1 column 3.</value>
        public float R1C3
        {
            get { return mR1C3; }
        }

        /// <summary>
        /// Gets the value of row 1 column 4.
        /// </summary>
        /// <value>The value of row 1 column 4.</value>
        public float R1C4
        {
            get { return mR1C4; }
        }

        /// <summary>
        /// Gets the value of row 2 column 1.
        /// </summary>
        /// <value>The value of row 2 column 1.</value>
        public float R2C1
        {
            get { return mR2C1; }
        }

        /// <summary>
        /// Gets the value of row 2 column 2.
        /// </summary>
        /// <value>The value of row 2 column 2.</value>
        public float R2C2
        {
            get { return mR2C2; }
        }

        /// <summary>
        /// Gets the value of row 2 column 3.
        /// </summary>
        /// <value>The value of row 2 column 3.</value>
        public float R2C3
        {
            get { return mR2C3; }
        }

        /// <summary>
        /// Gets the value of row 2 column 4.
        /// </summary>
        /// <value>The value of row 2 column 4.</value>
        public float R2C4
        {
            get { return mR2C4; }
        }

        /// <summary>
        /// Gets the value of row 3 column 1.
        /// </summary>
        /// <value>The value of row 3 column 1.</value>
        public float R3C1
        {
            get { return mR3C1; }
        }

        /// <summary>
        /// Gets the value of row 3 column 2.
        /// </summary>
        /// <value>The value of row 3 column 2.</value>
        public float R3C2
        {
            get { return mR3C2; }
        }

        /// <summary>
        /// Gets the value of row 3 column 3.
        /// </summary>
        /// <value>The value of row 3 column 3.</value>
        public float R3C3
        {
            get { return mR3C3; }
        }

        /// <summary>
        /// Gets the value of row 3 column 4.
        /// </summary>
        /// <value>The value of row 3 column 4.</value>
        public float R3C4
        {
            get { return mR3C4; }
        }

        /// <summary>
        /// Gets the value of row 4 column 1.
        /// </summary>
        /// <value>The value of row 4 column 1.</value>
        public float R4C1
        {
            get { return mR4C1; }
        }

        /// <summary>
        /// Gets the value of row 4 column 2.
        /// </summary>
        /// <value>The value of row 4 column 2.</value>
        public float R4C2
        {
            get { return mR4C2; }
        }

        /// <summary>
        /// Gets the value of row 4 column 3.
        /// </summary>
        /// <value>The value of row 4 column 3.</value>
        public float R4C3
        {
            get { return mR4C3; }
        }

        /// <summary>
        /// Gets the value of row 4 column 4.
        /// </summary>
        /// <value>The value of row 4 column 4.</value>
        public float R4C4
        {
            get { return mR4C4; }
        }
    }
}